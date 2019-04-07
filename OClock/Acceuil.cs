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
        public Acceuil(ref switcher a)
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();
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
            switcher ouai = new switcher();
            Form1 alarmSeting = new Form1(ref ouai);
            alarmSeting.Closed += (s, args) => this.Close();
            alarmSeting.Show();
        }
    }
}
