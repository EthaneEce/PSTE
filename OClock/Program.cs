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
            bool end = false;
            switcher ouai = new switcher();
            ouai.alarmActive = false;
            ouai.alarmRinging = false;
            ouai.alarmSeted = false;
            ouai.urlAlarm = "";
            ouai.page = 2;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Acceuil acceuil = new Acceuil(ref ouai);
            Form1 alarmSetting = new Form1(ref ouai);
            Form2 radioSetting = new Form2(ref ouai);

            Application.Run(acceuil);

            /*
            while (end == false)
            {
                if (ouai.page == 1)
                {
                    Application.Run(acceuil);
                    acceuil.Show();
                    alarmSetting.Hide();
                    radioSetting.Hide();
                }
                if (ouai.page == 2)
                {
                    //Application.Run(alarmSetting);
                    acceuil.Hide();
                    alarmSetting.Show();
                    radioSetting.Hide();
                }
                if (ouai.page == 3)
                {
                    Application.Run(radioSetting);
                    acceuil.Hide();
                    alarmSetting.Hide();
                    radioSetting.Show();
                }
            };*/

        }
    }
}
