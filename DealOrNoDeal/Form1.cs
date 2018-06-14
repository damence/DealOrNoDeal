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
    public partial class Form1 : Form
    {
        bool firstGame;

        public Form1()
        {
            InitializeComponent();
            firstGame = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            System.Media.SoundPlayer soundPlayer = 
                new System.Media.SoundPlayer(Properties.Resources.entrysound);
            soundPlayer.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            GameForm newGame = new GameForm();
            newGame.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "Правила на играта" + Environment.NewLine
                + Environment.NewLine + "Играчот отвара кутии од понудените се додека"
                + Environment.NewLine + "не е задоволен од понудата или стигне до последната"
                + Environment.NewLine + "кутија. По секои неколку отворени кутии, добива"
                + Environment.NewLine + "повик од банкарот кој му дава одредена понуда"
                + Environment.NewLine + "која може да ја прифати или да ја одбие.";
            MessageBox.Show(msg);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
