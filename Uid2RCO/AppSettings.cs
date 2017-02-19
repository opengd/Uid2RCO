using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Uid2RCO
{
    [DataContract()]
    internal class AppSettings
    {
        [DataMember]
        internal bool isEnable;

        [DataMember]
        internal bool outputForeground;

        [DataMember]
        internal bool outputClipboard;

        [DataMember]
        internal string outputString;

        [DataMember]
        internal string clipboardoOutputString;

        [DataMember]
        internal bool minimizeToTray;

        [DataMember]
        internal bool minimizeToTrayOnAppStart;
    }
}
