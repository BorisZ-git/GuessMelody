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
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            MakeMusic();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
        }
    }
}
