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
    public partial class GameForm : Form
    {
        Game currentGame;

        public GameForm()
        {
            InitializeComponent();
            currentGame = new Game();
            startGame();
        }

        public void startGame()
        {
            pictureBox1.Image = DealOrNoDeal.Properties.Resources.box1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Properties.Resources.box5;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Properties.Resources.box10;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Properties.Resources.box25;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Properties.Resources.box50;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Properties.Resources.box100;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Properties.Resources.box250;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Image = Properties.Resources.box500;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.Image = Properties.Resources.box1000;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.Image = Properties.Resources.box2500;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.Image = Properties.Resources.box5000;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.Image = Properties.Resources.box10k;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.Image = Properties.Resources.box50k;
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.Image = Properties.Resources.box100k;
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.Image = Properties.Resources.box500k;
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.Image = Properties.Resources.box1mill;
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void boxesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseBoxButton_Click(object sender, EventArgs e)
        {
            openedBoxLabel.Text = currentGame.OpenBox().ToString();
        }

        private void openedBoxLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button5.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button4.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button10.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button11.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button12.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button13.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button15.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            button16.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void refresh(int openedSum)
        {
            switch (openedSum)
            {
                case 1:
                    pictureBox1.Image = null;
                    break;
                case 5:
                    pictureBox2.Image = null;
                    break;
                case 10:
                    pictureBox3.Image = null;
                    break;
                case 25:
                    pictureBox4.Image = null;
                    break;
                case 50:
                    pictureBox5.Image = null;
                    break;
                case 100:
                    pictureBox6.Image = null;
                    break;
                case 250:
                    pictureBox7.Image = null;
                    break;
                case 500:
                    pictureBox8.Image = null;
                    break;
                case 1000:
                    pictureBox9.Image = null;
                    break;
                case 2500:
                    pictureBox10.Image = null;
                    break;
                case 5000:
                    pictureBox11.Image = null;
                    break;
                case 10000:
                    pictureBox12.Image = null;
                    break;
                case 50000:
                    pictureBox13.Image = null;
                    break;
                case 100000:
                    pictureBox14.Image = null;
                    break;
                case 500000:
                    pictureBox15.Image = null;
                    break;
                case 1000000:
                    pictureBox16.Image = null;
                    break;
            }
            if (currentGame.getTurn() == 4 || currentGame.getTurn() == 7 || 
                currentGame.getTurn() == 10 || currentGame.getTurn() == 12 ||
                currentGame.getTurn() == 14 )
            {
                BankerForm banker = new BankerForm(currentGame);
                banker.ShowDialog();
                if (banker.DialogResult == DialogResult.OK)
                    banker.Close();
                if( banker.DialogResult == DialogResult.Cancel)
                {
                    banker.Close();
                    this.Close();
                }


            }
        }
    }
}
