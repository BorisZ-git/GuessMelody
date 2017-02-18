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
            Victorina.WriteSettings();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdMusic_List = new FolderBrowserDialog();
            if (fbdMusic_List.ShowDialog() == DialogResult.OK)
            {
                string[] Music_List = Directory.GetFileSystemEntries(fbdMusic_List.SelectedPath,"*mp3",
                cbAllDirectory.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                lbMusic.Items.Clear();
                lbMusic.Items.AddRange(Music_List);
                Victorina.list.Clear();
                Victorina.list.AddRange(Music_List);
            }
        }
    }
}
