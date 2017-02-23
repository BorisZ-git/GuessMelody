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
    public partial class fMessage : Form
    {
        int timeAnswer = Victorina.timeAnswer;
        public fMessage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeAnswer--;
            lblTimeAnswer.Text = timeAnswer.ToString();
            if (timeAnswer == 0)
            {
                timer1.Stop();
            }
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            timeAnswer = Victorina.timeAnswer;
            lblTimeAnswer.Text = timeAnswer.ToString();
            timer1.Start();            
        }

    }
}
