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
        private List<radio> list = new List<radio>();
        public static object Control { get; private set; }

        public Form1(ref switcher a)
        {
            InitializeComponent();
            ouai = a;

            label2.Text = this.hourDozen.ToString();
            label3.Text = this.hourUnit.ToString();
            label4.Text = this.minuteDozen.ToString();
            label5.Text = this.minuteUnit.ToString();

            fillRadioList();
            radioCBo.DataSource = this.list;
            radioCBo.ValueMember = "url";
            radioCBo.DisplayMember = "name";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ouai.alarmActive = true;

            Acceuil accueil = new Acceuil(ref this.ouai);
            accueil.Closed += (s, args) => this.Close();
            accueil.Show();
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
            this.ouai.alarmActive = false;
            this.Hide();
            Acceuil accueil = new Acceuil(ref this.ouai);
            accueil.Closed += (s, args) => this.Close();
            accueil.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void radioCBo_SelectedIndexChanged(object sender, EventArgs e)
        {
            radio obj = radioCBo.SelectedItem as radio;
            if (obj != null)
                this.ouai.urlAlarm = obj.url;
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

        private void fillRadioList()
        {
            this.list.Add(new radio() { url = "http://direct.franceinter.fr/live/franceinter-midfi.mp3", name = "France Inter" });
            this.list.Add(new radio() { url = "http://direct.franceinfo.fr/live/franceinfo-midfi.mp3", name = "Franceinfo" });
            this.list.Add(new radio() { url = "http://direct.franceculture.fr/live/franceculture-midfi.mp3", name = "France Culture" });
            this.list.Add(new radio() { url = "http://direct.francemusique.fr/live/francemusique-midfi.mp3", name = "France Musique" });
            this.list.Add(new radio() { url = "http://direct.francemusique.fr/live/francemusiqueocoramonde-hifi.mp3", name = "France Musique | Musiques du monde - Ocora " });
            this.list.Add(new radio() { url = "http://direct.mouv.fr/live/mouv-lofi.mp3", name = "Mouv'" });
            this.list.Add(new radio() { url = "http://direct.fipradio.fr/live/fip-lofi.mp3", name = "FIP" });
            this.list.Add(new radio() { url = "http://direct.fipradio.fr/live/fip-webradio6.mp3", name = "FIP reggae" });
            this.list.Add(new radio() { url = "http://direct.fipradio.fr/live/fip-webradio2.mp3", name = "FIP jazz" });
            this.list.Add(new radio() { url = "http://direct.fipradio.fr/live/fip-webradio1.mp3", name = "FIP rock" });
            this.list.Add(new radio() { url = "http://stream1.chantefrance.com/Chante_France", name = "Chante France" });
            this.list.Add(new radio() { url = "http://cdn.nrjaudio.fm/audio1/fr/30601/mp3_128.mp3?origine=fluxradios", name = "Nostalgie" });
            this.list.Add(new radio() { url = "http://tsfjazz.ice.infomaniak.ch/tsfjazz-high.mp3", name = "TSF Jazz" });
            this.list.Add(new radio() { url = "http://stream.cheriefm.be/cheriefm", name = "Cherie FM" }); 
            this.list.Add(new radio() { url = "http://radioj.hbgt.infoclip.fr:8000/radioj", name = "Radio J" });
            this.list.Add(new radio() { url = "http://www.skyrock.fm/stream.php/tunein16_128mp3.mp3", name = "Skyrock" });
            this.list.Add(new radio() { url = "http://cdn.nrjaudio.fm/audio1/fr/40105/mp3_128.mp3", name = "Rire & Chansons" });
            this.list.Add(new radio() { url = "http://cdn.nrjaudio.fm/audio1/fr/30001/mp3_128.mp3?origine=fluxradios", name = "NRJ" });
            this.list.Add(new radio() { url = "http://streaming.radio.funradio.fr/fun-1-48-192", name = "Fun Radio" });
            this.list.Add(new radio() { url = "http://mfm.ice.infomaniak.ch/mfm-128.mp3", name = "M Radio" });
            this.list.Add(new radio() { url = "http://vr-live-mp3-128.scdn.arkena.com/virginradio.mp3", name = "Virgin Radio" });
            this.list.Add(new radio() { url = "http://rfm-live-mp3-128.scdn.arkena.com/rfm.mp3", name = "RFM" });
            this.list.Add(new radio() { url = "http://streaming.radio.rtl.fr/rtl-1-48-192", name = "RTL" });
            this.list.Add(new radio() { url = "http://e1-live-mp3-128.scdn.arkena.com/europe1.mp3", name = "Europe 1" });
        }
    }
}
