﻿using System;
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
        private void btnNext_Click(object sender, EventArgs e)
        {
            WMP.URL = Victorina.list[rnd()];
        }
        private int rnd()
        {
            return random.Next(0, Victorina.list.Count);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
