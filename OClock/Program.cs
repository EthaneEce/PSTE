using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OClock
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            switcher ouai = new switcher();
            ouai.alarmActive = false;
            ouai.alarmRinging = false;
            ouai.urlAlarm = string.Empty;
            ouai.radioName = "Radio non choisie";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            Application.Run(new Acceuil(ref ouai));


        }
    }
}
