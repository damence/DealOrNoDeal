using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealOrNoDeal
{
    public partial class BankerForm : Form
    {
        public BankerForm(Game game)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            sumLabel.Text = game.calculateOffer().ToString();
            System.Media.SoundPlayer soundPlayer =
                new System.Media.SoundPlayer(Properties.Resources.audiofile);
            soundPlayer.Play();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BankerForm_Load(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            System.Media.SoundPlayer player =
                new System.Media.SoundPlayer(Properties.Resources.applausesound);
            player.Play();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            System.Media.SoundPlayer player =
                new System.Media.SoundPlayer(Properties.Resources.applausesound);
            player.Play();
        }

        private void acceptContinueButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
