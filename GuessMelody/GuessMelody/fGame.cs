﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessMelody
{
    public partial class fGame : Form
    {
        public fGame()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int MusicDuration = Victorina.MusicDuration;
        fMessage FGM = new fMessage();
        bool[] players = new bool[2];
        void MakeMusic()
        {
            if (Victorina.list.Count == 0) EndGame();
            else
            {
                int rnd = random.Next(0, Victorina.list.Count);
                WMP.URL = Victorina.list[rnd];
                //WMP.Ctlcontrols.play();
                Victorina.list.RemoveAt(rnd);
                lblMusicCount.Text = Victorina.list.Count.ToString();
                MusicDuration = Victorina.MusicDuration;
                lblMusicDuration.Text = MusicDuration.ToString();
                players[0] = false;
                players[1] = false;
                Victorina.Answer = WMP.URL;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            GamePause();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = Victorina.GameDuration;
            lblMusicCount.Text = Victorina.list.Count.ToString();
            lblMusicDuration.Text = MusicDuration.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            MusicDuration--;
            lblMusicDuration.Text = MusicDuration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if (MusicDuration == 0)
            {
                MakeMusic();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GameContinue();
        }

        void GameContinue()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }
        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }
        void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }
        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled) return;
            SoundPlayer sp = new SoundPlayer("Properties\\Answer.wav");
            if (players[0] == false && e.KeyData == Keys.A)
            {
                sp.PlaySync();
                GamePause();
                FGM.lblName.Text = "Player 1";
                players[0] = true;
                if (FGM.ShowDialog() == DialogResult.Yes)
                {
                    lblCounter1.Text = Convert.ToString(Convert.ToInt32(lblCounter1.Text) + 1);
                    MakeMusic();
                } 
                else GameContinue();
            }
            if (players[1] == false && e.KeyData == Keys.P)
            {
                players[1] = true;
                sp.PlaySync();
                GamePause();
                FGM.lblName.Text = "Player 2";
                if (FGM.ShowDialog() == DialogResult.Yes)
                {
                    lblCounter2.Text = Convert.ToString(Convert.ToInt32(lblCounter2.Text) + 1);
                    MakeMusic();
                }
                else GameContinue();
            }

        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.RandomStart)
            {
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                {
                    WMP.Ctlcontrols.currentPosition = random.Next(0, (int)WMP.currentMedia.duration / 2);
                }
            }
        }

        private void lblCounter1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                (sender as Label).Text = Convert.ToString
                    (Convert.ToInt32((sender as Label).Text) + 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                (sender as Label).Text = Convert.ToString
                    (Convert.ToInt32((sender as Label).Text) - 1);
            }

        }
    }
}
