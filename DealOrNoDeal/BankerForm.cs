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
            sumLabel.Text = game.calculateOffer().ToString();

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
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
