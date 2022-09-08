using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sporoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random ras = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int gs = 0;
        int fb = 0;
        int bjk = 0;
        int van = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int fenerbahce = ras.Next(0, 6);
            int galatasaray = ras.Next(0, 6);
            int besiktas = ras.Next(0, 6);
            int vanspor = ras.Next(0, 6);
            label4.Text = fenerbahce.ToString();
            label5.Text = galatasaray.ToString();
            label7.Text = besiktas.ToString();
            label6.Text = vanspor.ToString();
            if (Convert.ToInt16(label6.Text) == Convert.ToInt16(label7.Text))
            {
                van += 1;
                bjk += 1;
                lbl_bjk.Text = bjk.ToString();
                lbl_van.Text = van.ToString();
            }
            if (Convert.ToInt16(label6.Text) > Convert.ToInt16(label7.Text))
            {
                van = +3;
                lbl_van.Text = van.ToString();
            }
            if (Convert.ToInt16(label6.Text) < Convert.ToInt16(label7.Text))
            {
                bjk += 3;
                lbl_bjk.Text = bjk.ToString();
            }
            if (Convert.ToInt16(label4.Text) == Convert.ToInt16(label5.Text))
            {
                fb += 1;
                gs += 1;
                lbl_fb.Text = bjk.ToString();
                lbl_gs.Text = van.ToString();
            }
            if (Convert.ToInt16(label4.Text) > Convert.ToInt16(label5.Text))
            {
                fb = +3;
                lbl_fb.Text = fb.ToString();
            }
            if (Convert.ToInt16(label4.Text) < Convert.ToInt16(label5.Text))
            {
                gs += 3;
                lbl_gs.Text = gs.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int fenerbahce = ras.Next(0, 6);
            int galatasaray = ras.Next(0, 6);
            int besiktas = ras.Next(0, 6);
            int vanspor = ras.Next(0, 6);
            label17.Text = fenerbahce.ToString();
            label12.Text = galatasaray.ToString();
            label16.Text = besiktas.ToString();
            label11.Text = vanspor.ToString();
            if (Convert.ToInt32(label17.Text) == Convert.ToInt32(label16.Text))
            {
                fb += 1;
                bjk += 1;
                lbl_bjk.Text = besiktas.ToString();
                lbl_fb.Text = fb.ToString();
            }
            if (Convert.ToInt32(label17.Text) > Convert.ToInt32(label16.Text))
            {
                fb += 3;
                lbl_fb.Text = fb.ToString();
            }
            if (Convert.ToInt32(label17.Text) < Convert.ToInt32(label16.Text))
            {
                bjk += 3;
                lbl_bjk.Text = besiktas.ToString();
            }
            if (Convert.ToInt32(label12.Text) == Convert.ToInt32(label11.Text))
            {
                van += 1;
                gs += 1;
                lbl_van.Text = van.ToString();
                lbl_gs.Text = gs.ToString();
            }
            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label11.Text))
            {
                gs += 3;
                lbl_gs.Text = gs.ToString();
            }
            if (Convert.ToInt32(label12.Text) < Convert.ToInt32(label11.Text))
            {
                van += 3;
                lbl_van.Text = van.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int fenerbahce = ras.Next(0, 6);
            int galatasaray = ras.Next(0, 6);
            int besiktas = ras.Next(0, 6);
            int vanspor = ras.Next(0, 6);
            label27.Text = fenerbahce.ToString();
            label26.Text = galatasaray.ToString();
            label22.Text = besiktas.ToString();
            label21.Text = vanspor.ToString();

            if (Convert.ToInt32(label21.Text) == Convert.ToInt32(label27.Text))
            {
                van += 1;
                fb += 1;
                lbl_fb.Text = fb.ToString();
                lbl_van.Text = van.ToString();
            }
            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label27.Text))
            {
                van += 3;
                lbl_van.Text = van.ToString();
            }
            if (Convert.ToInt32(label21.Text) < Convert.ToInt32(label27.Text))
            {
                fb += 3;
                lbl_fb.Text = fb.ToString();
            }
            if (Convert.ToInt16(label22.Text) == Convert.ToInt16(label26.Text))
            {
                gs += 1;
                bjk += 1;
                lbl_gs.Text = gs.ToString();
                lbl_bjk.Text = bjk.ToString();
            }
            if (Convert.ToInt16(label22.Text) > Convert.ToInt16(label26.Text))
            {
                bjk += 3;
                lbl_bjk.Text = bjk.ToString();
            }
            if (Convert.ToInt16(label22.Text) < Convert.ToInt16(label26.Text))
            {
                gs += 3;
                lbl_gs.Text = gs.ToString();
            }
            if (Convert.ToInt16(lbl_gs.Text) > Convert.ToInt16(lbl_fb.Text) && Convert.ToInt32(lbl_gs.Text) > Convert.ToInt32(lbl_van.Text) && Convert.ToInt32(lbl_gs.Text) > Convert.ToInt32(lbl_bjk.Text))
            {
                
                axWindowsMediaPlayer1.URL = "C:\\Users\\MONSTER\\Downloads\\gs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\gs.jpg";
                MessageBox.Show("ŞAMPİYON 6ALATASARAY");
            }
            if (Convert.ToInt16(lbl_fb.Text) > Convert.ToInt16(lbl_gs.Text) && Convert.ToInt32(lbl_fb.Text) > Convert.ToInt32(lbl_van.Text) && Convert.ToInt32(lbl_fb.Text) > Convert.ToInt32(lbl_bjk.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\MONSTER\\Downloads\\fb.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\fb.jpeg";
                MessageBox.Show("ŞAMPİYON FENERBAHÇE");
            }
            if (Convert.ToInt16(lbl_bjk.Text) > Convert.ToInt16(lbl_fb.Text) && Convert.ToInt32(lbl_bjk.Text) > Convert.ToInt32(lbl_van.Text) && Convert.ToInt32(lbl_bjk.Text) > Convert.ToInt32(lbl_gs.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\MONSTER\\Downloads\\bjk.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\bjk.jpg";
                MessageBox.Show("ŞAMPİYON 8TAŞ");
            }
            if (Convert.ToInt16(lbl_van.Text) > Convert.ToInt16(lbl_fb.Text) && Convert.ToInt32(lbl_van.Text) > Convert.ToInt32(lbl_gs.Text) && Convert.ToInt32(lbl_van.Text) > Convert.ToInt32(lbl_bjk.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\MONSTER\\Downloads\\van.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\MONSTER\\Desktop\\van.jpg";
                MessageBox.Show("ŞAMPİYON KARAKOBRALAR");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
