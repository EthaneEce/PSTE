using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OClock
{
    public struct switcher
    {
        public bool alarmActive , alarmRinging;
        public string urlAlarm, radioName;
        public DateTime alarmTime;
    }

    public class radio
    {
        public string url { get; set; }

        public string name { get; set; }
    }
}
