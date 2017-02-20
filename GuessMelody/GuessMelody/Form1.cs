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
    public partial class FmMain : Form
    {
        fmSettings fmParam = new fmSettings();
        fGame fmGame = new fGame();

        public FmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            fmParam.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmGame.Show();
        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            Victorina.ReadSettings();
            Victorina.ReadMusic();
        }
    }
}
