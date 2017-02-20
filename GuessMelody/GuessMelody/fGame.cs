using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class fGame : Form
    {
        public fGame()
        {
            InitializeComponent();
        }
        Random random = new Random();
        void MakeMusic()
        {
            int rnd = random.Next(0, Victorina.list.Count);
            WMP.URL = Victorina.list[rnd];
            //WMP.Ctlcontrols.play();
            Victorina.list.RemoveAt(rnd);
            lblMusicCount.Text = Victorina.list.Count.ToString();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = Victorina.GameDuration;
            lblMusicCount.Text = Victorina.list.Count.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }
    }
}
