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
    public partial class CongratsForm : Form
    {
        Ognomet[] fireworks = new Ognomet[10];
        static Random rand = new Random();

        public CongratsForm(int amount)
        {
            InitializeComponent();
            string p = String.Concat(amount.ToString(), " денари");
            p = String.Concat("Честитки, вие освоивте  \r\n", p);
            label2.Text = p;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            ClientSize = new Size(700, 600);
            timer1.Interval = 10;
            timer1.Start();
        }

        private void CongratsForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; ++i)
                if (fireworks[i] != null)
                    if (!fireworks[i].Update())
                        fireworks[i] = null;
            
            if (rand.Next(10) == 0)
                for (int i = 0; i <10; ++i)
                    if (fireworks[i] == null)
                    {
                        fireworks[i] = new Ognomet(ClientRectangle.Width,
                                    ClientRectangle.Height);
                        break;
                    }

            Invalidate();
            Update();
        }

        private void CongratsForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(192, 192, 255));
            foreach (Ognomet fw in fireworks)
                if (fw != null)
                    fw.Paint(e.Graphics);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
