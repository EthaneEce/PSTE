using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OClock
{
    public struct switcher
    {
        public bool alarmActive , alarmRinging, alarmSeted;
        public string urlAlarm;
        public int page; //1 : accueil, 2 : Alarm Set, 3 : Radio Selec
    }
}
