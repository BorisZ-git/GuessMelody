using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessMelody
{
    public partial class fmSettings : Form
    {
        public fmSettings()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Victorina.GameDuration = Convert.ToInt32(cmbGameDuration.Text);
            Victorina.MusicDuration = Convert.ToInt32(cmbMusicDuration.Text);
            Victorina.AllDirectories = cbAllDirectory.Checked;
            Victorina.RandomStart = cbRandomStart.Checked;
            Victorina.WriteSettings();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdMusic_List = new FolderBrowserDialog();
            if (fbdMusic_List.ShowDialog() == DialogResult.OK)
            {
                string[] Music_List = Directory.GetFileSystemEntries(fbdMusic_List.SelectedPath,"*mp3",
                cbAllDirectory.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                Victorina.LastFolder = fbdMusic_List.SelectedPath;
                lbMusic.Items.Clear();
                lbMusic.Items.AddRange(Music_List);
                Victorina.list.Clear();
                Victorina.list.AddRange(Music_List);
            }
        }
        void Set()
        {
            cmbGameDuration.Text = Victorina.GameDuration.ToString();
            cmbMusicDuration.Text = Victorina.MusicDuration.ToString();
            cbAllDirectory.Checked = Victorina.AllDirectories;
            cbRandomStart.Checked = Victorina.RandomStart;
        }

        private void fmSettings_Load(object sender, EventArgs e)
        {            
            Set();
            lbMusic.Items.Clear();
            lbMusic.Items.AddRange(Victorina.list.ToArray());
        }
    }
}
