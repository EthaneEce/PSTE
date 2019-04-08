using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OClock
{
    public partial class Acceuil : Form
    {
        private switcher ouai;

        public Acceuil(ref switcher a)
        {
            InitializeComponent();
            this.ouai = a;
           
            label1.Text = DateTime.Now.ToLongTimeString();
            if (this.ouai.alarmActive)
            {
                label2.Text = "Heure de l'alarme : " + this.ouai.alarmTime.ToShortTimeString();
                label3.Text = "Radio de l'alarme : " + this.ouai.radioName;
            }                
            else
            {
                label2.Text = "Alarme éteinte";
                label3.Text = "";
            }
               
            

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();
            if(DateTime.Now.Hour == this.ouai.alarmTime.Hour && DateTime.Now.Minute == this.ouai.alarmTime.Minute && this.ouai.alarmActive)
            {
                this.ouai.alarmRinging = true;
                playRadio();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 alarmSeting = new Form1(ref this.ouai);
            alarmSeting.Closed += (s, args) => this.Close();
            alarmSeting.Show();
        }
        
        private void playRadio()
        {
            if (this.ouai.alarmRinging)
            {
                axVLCPlugin21.playlist.add(this.ouai.urlAlarm);
                axVLCPlugin21.playlist.play();
            }                
            else
                axVLCPlugin21.playlist.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ouai.alarmRinging = false;
            playRadio();
        }

    }
}
