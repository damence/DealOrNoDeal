using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DealOrNoDeal
{
    public class Ognomet
    {
        const int maxRays = 10;
        double start, stop, len, currPos, descent;
        SolidBrush brush;
        int nrays;
        int cx, cy;
        double[] sintab;
        double[] costab;
        static Random rand = new Random();
        const double Step = 0.5;

        public Ognomet(int xsize, int ysize)
        {
            cx = rand.Next(xsize);
            cy = rand.Next(ysize);
            descent = rand.NextDouble() * 0.1 + 0.05;

            start = rand.NextDouble() * 10 + 5;
            stop = rand.NextDouble() * 50 + 50;
            len = rand.NextDouble() * 50 + 25;

            currPos = start;

            brush = new SolidBrush(Color.FromArgb(rand.Next(128, 256),
                                  rand.Next(128, 256),
                                  rand.Next(128, 256)));

            nrays = rand.Next(5, maxRays + 1);

            double angleInc = 2 * Math.PI / nrays;
            double angle = rand.NextDouble() * angleInc;

            costab = new double[nrays];
            sintab = new double[nrays];
            for (int i = 0; i < nrays; ++i, angle += angleInc)
            {
                costab[i] = Math.Cos(angle);
                sintab[i] = Math.Sin(angle);
            }
        }

        public void Paint(Graphics g)
        {
            double lower = Math.Max(currPos - len, start);
            double upper = Math.Min(currPos, stop);

            for (double pos = lower; pos < upper; pos += Step)
            {
                double quad = descent * pos;
                double quadsq = quad * quad;

                for (int i = 0; i < nrays; ++i)
                    g.FillRectangle(brush,
                            (int)(cx + pos * costab[i]),
                            (int)(cy + pos * sintab[i] + quadsq),
                            1, 1);
            }
        }

        public bool Update()
        {
            currPos += Step;
            return currPos <= stop + len;
        }



    }
}
