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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            currentGame = new Game();
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
            Controls.Remove(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int openedSum = currentGame.OpenBox();
            openedBoxLabel.Text = openedSum.ToString();
            refresh(openedSum);
            Controls.Remove(button16);
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
            Invalidate();
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
                    CongratsForm congratsForm = new CongratsForm(currentGame.calculateOffer());
                    congratsForm.ShowDialog();
                    this.Close();
                }


            }
            if (currentGame.getTurn() == 15)
            {
                CongratsForm congratsForm = new CongratsForm(currentGame.getBoxes().Max());
                congratsForm.ShowDialog();
                this.Close();
            }


        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
    }
}
