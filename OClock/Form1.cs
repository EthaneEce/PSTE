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
    public partial class Form1 : Form
    {
        private int hourDozen = 0, hourUnit = 0, minuteDozen = 0, minuteUnit = 0 ;
        private switcher ouai;

        public static object Control { get; private set; }

        public Form1(ref switcher a)
        {
            InitializeComponent();

            this.ouai = a;

            label2.Text = this.hourDozen.ToString();
            label3.Text = this.hourUnit.ToString();
            label4.Text = this.minuteDozen.ToString();
            label5.Text = this.minuteUnit.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            switcher ouai = new switcher();
            Acceuil accueil = new Acceuil(ref ouai);
            accueil.Closed += (s, args) => this.Close();
            accueil.Show();
        }

        private void changePage(int a)
        {
            this.ouai.page = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.hourUnit++;
            if (this.hourDozen != 2)
            {                
                if (this.hourUnit == 10)
                    this.hourUnit = 0 ;
            }
            else
            {
                if (this.hourUnit == 4)
                    this.hourUnit = 0;
            }
            label3.Text = this.hourUnit.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.minuteUnit++;
            if (this.minuteUnit == 10)
                this.minuteUnit = 0;

            label5.Text = this.minuteUnit.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.hourDozen++;
            if (this.hourDozen == 3)
                this.hourDozen = 0;

            if (this.hourDozen == 2 && this.hourUnit > 3)
                this.hourUnit = 0;

            label2.Text = this.hourDozen.ToString();
            label3.Text = this.hourUnit.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.minuteDozen++;
            if (this.minuteDozen == 6)
                this.minuteDozen = 0;

            label4.Text = this.minuteDozen.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.hourDozen--;
            if (this.hourDozen == -1)
                this.hourDozen = 2;

            if (this.hourDozen == 2 && this.hourUnit > 3)
                this.hourUnit = 0;

            label2.Text = this.hourDozen.ToString();
            label3.Text = this.hourUnit.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //this.activated = false ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            switcher ouai = new switcher();
            Form2 radioStting = new Form2(ref ouai);
            radioStting.Closed += (s, args) => this.Close();
            radioStting.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.hourUnit--;
            if (this.hourDozen != 2)
            {
                if (this.hourUnit == -1)
                    this.hourUnit = 9;
            }
            else
            {
                if (this.hourUnit == -1)
                    this.hourUnit = 3;
            }
            label3.Text = this.hourUnit.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.minuteDozen--;
            if (this.minuteDozen == -1)
                this.minuteDozen = 5;

            label4.Text = this.minuteDozen.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.minuteUnit--;
            if (this.minuteUnit == -1)
                this.minuteUnit = 9;

            label5.Text = this.minuteUnit.ToString();
        }
    }
}
