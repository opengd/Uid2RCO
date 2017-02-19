using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCSC;
using PCSC.Iso7816;
using System.Diagnostics;
using System.Threading;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Uid2RCO
{
    public partial class Form1 : Form
    {
        private static readonly IContextFactory _contextFactory = ContextFactory.Instance;

        public Form1()
        {
            InitializeComponent();
 
            LoadSettings();

            buttonReaderRefresh_Click(null, null);
        }

        private void Monitor_CardInserted(object sender, CardStatusEventArgs e)
        {
            using (var context = _contextFactory.Establish(SCardScope.System))
            {
                // 'using' statement to make sure the reader will be disposed (disconnected) on exit
                using (var rfidReader = new SCardReader(context))
                {
                    var sc = rfidReader.Connect(e.ReaderName, SCardShareMode.Shared, SCardProtocol.Any);
                    if (sc != SCardError.Success)
                    {
                        Debug.WriteLine("Could not connect to reader {0}:\n{1}",
                            e.ReaderName,
                            SCardHelper.StringifyError(sc));
                        return;
                    }

                    var apdu = new CommandApdu(IsoCase.Case2Short, rfidReader.ActiveProtocol)
                    {
                        CLA = 0xFF,
                        Instruction = InstructionCode.GetData,
                        P1 = 0x00,
                        P2 = 0x00,
                        Le = 0 // We don't know the ID tag size
                    };

                    sc = rfidReader.BeginTransaction();
                    if (sc != SCardError.Success)
                    {
                        Debug.WriteLine("Could not begin transaction.");
                        return;
                    }

                    Debug.WriteLine("Retrieving the UID .... ");

                    var receivePci = new SCardPCI(); // IO returned protocol control information.
                    var sendPci = SCardPCI.GetPci(rfidReader.ActiveProtocol);

                    var receiveBuffer = new byte[256];
                    var command = apdu.ToArray();

                    sc = rfidReader.Transmit(
                        sendPci, // Protocol Control Information (T0, T1 or Raw)
                        command, // command APDU
                        receivePci, // returning Protocol Control Information
                        ref receiveBuffer); // data buffer

                    if (sc != SCardError.Success)
                    {
                        Debug.WriteLine("Error: " + SCardHelper.StringifyError(sc));
                    }

                    var responseApdu = new ResponseApdu(receiveBuffer, IsoCase.Case2Short, rfidReader.ActiveProtocol);

                    Debug.WriteLine("\nRaw UID: " + (responseApdu.HasData ? BitConverter.ToString(responseApdu.GetData()) : "No uid received"));

                    rfidReader.EndTransaction(SCardReaderDisposition.Leave);
                    rfidReader.Disconnect(SCardReaderDisposition.Reset);

                    if (responseApdu.HasData)
                    {
                        SendRco(UidToRco(responseApdu.GetData()), BitConverter.ToString(responseApdu.GetData()), e.ReaderName);
                    }
                }
            }
        }

        private static string[] GetReaderNames()
        {
            using (var context = _contextFactory.Establish(SCardScope.System))
            {
                return context.GetReaders();
            }
        }

        private static bool NoReaderFound(ICollection<string> readerNames)
        {
            return readerNames == null || readerNames.Count < 1;
        }

        private static string UidToRco(byte[] uid)
        {
            var tmp = BitConverter.ToUInt32(uid, 0);
            Debug.WriteLine("tmp: " + tmp);
            var part1 = (tmp / 0x10000) % 10000;
            var part2 = (tmp - (part1 * 0x10000) - 0x10000 * 10000) % 0x10000;
            var rconumber = part1 * 100000 + part2;
            Debug.WriteLine("part1: " + part1);
            Debug.WriteLine("part2: " + part2);
            Debug.WriteLine("rconumber: " + rconumber);

            return rconumber.ToString();
        }

        private void SendRco(string rco, string uid, string readername)
        {
            var now = DateTime.Now.ToString();

            if (checkBoxOutputToForgroundWindow.Checked)
            {
                var output = textBoxOutput.Text.Replace("%RCO%", rco);
                output = output.Replace("%UID%", uid);
                output = output.Replace("%TIME%", now);
                output = output.Replace("%READER%", readername);

                SendKeys.SendWait(output);
            }

            if (checkBoxClipboard.Checked)
            {
                var output = textBoxClipboardOutput.Text.Replace("%RCO%", rco);
                output = output.Replace("%UID%", uid);
                output = output.Replace("%TIME%", now);
                output = output.Replace("%READER%", readername);

                Thread thread = new Thread(() => Clipboard.SetText(output));
                thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
                thread.Start();
                thread.Join();
            }

            textBoxLog.BeginInvoke((Action)(() => textBoxLog.AppendText(now + ":" + readername + ":UID:" + uid + ":RCO:" + rco + Environment.NewLine)));
        }

        private void backgroundWorkerReaderMonitor_DoWork(object sender, DoWorkEventArgs e)
        {
            var readerNames = GetReaderNames();

            if (readerNames.Length > 0)
            {
                using (var monitor = new SCardMonitor(_contextFactory, SCardScope.System))
                {
                    //AttachToAllEvents(monitor); // Remember to detach if you use this in production!

                    monitor.CardInserted += Monitor_CardInserted;

                    monitor.Start(readerNames);

                    while (!backgroundWorkerReaderMonitor.CancellationPending)
                    {
                        Thread.Sleep(10);
                    }

                    monitor.Cancel();
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState && checkBoxMinimizeToTray.Checked)
            {
                notifyIconApp.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconApp.Visible = false;
            }
        }

        private void notifyIconApp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItemChangeState_Click(object sender, EventArgs e)
        {
            ToggleState(!toolStripMenuItemChangeState.Checked);
        }

        private void checkBoxEnable_Click(object sender, EventArgs e)
        {
            ToggleState(checkBoxEnable.Checked);
        }

        private bool ToggleState(bool state)
        {
            checkBoxEnable.Checked = state;
            toolStripMenuItemChangeState.Checked = checkBoxEnable.Checked;

            if (checkBoxEnable.Checked)
            {
                buttonReaderRefresh_Click(null, null);
                //backgroundWorkerReaderMonitor.RunWorkerAsync();
                notifyIconApp.Text = this.Text + ": Enabled";
            }
            else
            {
                backgroundWorkerReaderMonitor.CancelAsync();
                notifyIconApp.Text = this.Text + ": Disabled";
            }

            return checkBoxEnable.Checked;
        }

        private void SaveSettings()
        {
            var s = new AppSettings();
            s.isEnable = checkBoxEnable.Checked;
            s.outputForeground = checkBoxOutputToForgroundWindow.Checked;
            s.outputClipboard = checkBoxClipboard.Checked;
            s.outputString = textBoxOutput.Text;
            s.clipboardoOutputString = textBoxClipboardOutput.Text;
            s.minimizeToTray = checkBoxMinimizeToTray.Checked;
            s.minimizeToTrayOnAppStart = checkBoxMinimizeToTrayOnAppStart.Checked;

            try
            {
                var writer = new FileStream("u2rsettings.json",
                    FileMode.OpenOrCreate);
                var ser = new DataContractJsonSerializer(typeof(AppSettings));
                ser.WriteObject(writer, s);

                writer.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Could not write settings file: " + e.Message);
            }
        }

        private void LoadSettings()
        {
            AppSettings s = null;
            try
            {
                var reader = new FileStream("u2rsettings.json",
                    FileMode.Open);
                var ser = new DataContractJsonSerializer(typeof(AppSettings));
                s = (AppSettings)ser.ReadObject(reader);

                reader.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Could not read settings file: " + e.Message);
            }

            if(s != null)
            {
                checkBoxEnable.Checked = s.isEnable;
                toolStripMenuItemChangeState.Checked = s.isEnable;
                checkBoxOutputToForgroundWindow.Checked = s.outputForeground;
                checkBoxClipboard.Checked = s.outputClipboard;
                textBoxOutput.Text = s.outputString;
                textBoxClipboardOutput.Text = s.clipboardoOutputString;
                checkBoxMinimizeToTray.Checked = s.minimizeToTray;
                checkBoxMinimizeToTrayOnAppStart.Checked = s.minimizeToTrayOnAppStart;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void buttonReaderRefresh_Click(object sender, EventArgs e)
        {
            labelReaderInfo.Text = string.Empty;

            var readercount = -1;

            foreach (var readers in GetReaderNames())
            {
                readercount++;
                labelReaderInfo.Text += "Reader " + readercount + ": " + readers + Environment.NewLine;
            }

            if (readercount >= 0 && checkBoxEnable.Checked)
            {
                if (backgroundWorkerReaderMonitor.IsBusy)
                {
                    backgroundWorkerReaderMonitor.CancelAsync();
                    while (backgroundWorkerReaderMonitor.CancellationPending)
                    {
                        Thread.Sleep(100);
                    }
                }
                backgroundWorkerReaderMonitor.RunWorkerAsync();
            }
            else
            {
                labelReaderInfo.Text = "Could not find any card reader.";
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (checkBoxMinimizeToTrayOnAppStart.Checked)
            {
                notifyIconApp.Visible = true;
                this.Hide();
            }
        }

        private void toolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
