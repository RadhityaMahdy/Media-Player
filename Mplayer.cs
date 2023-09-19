using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player
{
    public partial class Mplayer : Form
    {
        List<string> path = new List<string>();

        bool isMuted = false;

        public Mplayer()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";

            axWindowsMediaPlayer1.settings.autoStart = false;
            timer1.Enabled = true;
        }

        private void btnPlaying_Click(object sender, EventArgs e)
        {
            indicator.Top = btnPlaying.Top+3;
            bunifuPages1.SetPage(0);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            indicator.Top = btnPlaylist.Top+5;
            bunifuPages1.SetPage(1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "openFileDialog1.Filter = \"All Files|*.*";
            openFileDialog1.Title = "Select a media file";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path.Add(openFileDialog1.FileName);
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;

            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();

            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            timer1.Stop();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 5;
        }

        private void btnFastforward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 5;  
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "openFileDialog1.Filter = \"All Files|*.*";
            openFileDialog1.Title = "Select a media file";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path.Add(openFileDialog1.FileName);
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(openFileDialog1.FileName));

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];
            }
            catch (Exception e5)
            {
                MessageBox.Show(e5.Message);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;

            int currentMediaPosition = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            bunifuHSlider1.Value = currentMediaPosition;
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = bunifuHSlider1.Value;
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (isMuted)
            {
                axWindowsMediaPlayer1.settings.mute = false; // Unmute
                btnMute.Text = "Mute";
            }
            else
            {
                axWindowsMediaPlayer1.settings.mute = true; // Mute
                btnMute.Text = "Unmute";
            }

            isMuted = !isMuted;
        }

        private void volume_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = volume.Value;
            label1.Text = volume.Value.ToString();
        }
    }
}
