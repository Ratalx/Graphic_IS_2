using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krzywe
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue);
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, x4, y1, y2, y3, y4;
            Double.TryParse(textX1.Text, out x1);
            Double.TryParse(textX2.Text, out x2);
            Double.TryParse(textX3.Text, out x3);
            Double.TryParse(textX4.Text, out x4);

            Double.TryParse(textY1.Text, out y1);
            Double.TryParse(textY2.Text, out y2);
            Double.TryParse(textY3.Text, out y3);
            Double.TryParse(textY4.Text, out y4);


            g.Clear(Color.White);
            double prevX = x1;
            double prevY = y1;
            for(double t =0.1;t<1.0;t+=0.1)
            {
                double tempT = (1 - t);
                double qX = Math.Pow(tempT, 3) * x1 + Math.Pow(tempT, 2) * 3 * t * x2 + Math.Pow(t, 2) * 3 * tempT * x3 + Math.Pow(t, 3) * x4;
                double qY = Math.Pow(tempT, 3) * y1 + Math.Pow(tempT, 2) * 3 * t * y2 + Math.Pow(t, 2) * 3 * tempT * y3 + Math.Pow(t, 3) * y4;

                g.FillEllipse(new SolidBrush(Color.Black),(float) prevX-2.5f,(float) prevY-2.5f, 5.0f, 5.0f);
                g.DrawLine(pen1, (float)prevX,(float) prevY,(float) qX,(float) qY);
                prevX = qX;
                prevY = qY;
            }
            //g.DrawBezier(pen1, 0, 0, 50, 200, 200, 50, 300, 300);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, x4, y1, y2, y3, y4;
            Double.TryParse(textX1.Text, out x1);
            Double.TryParse(textX2.Text, out x2);
            Double.TryParse(textX3.Text, out x3);
            Double.TryParse(textX4.Text, out x4);

            Double.TryParse(textY1.Text, out y1);
            Double.TryParse(textY2.Text, out y2);
            Double.TryParse(textY3.Text, out y3);
            Double.TryParse(textY4.Text, out y4);


            double prevX = x1;
            double prevY = y1;


            g.Clear(Color.White);
            for(double t=0.1;t<1.0;t+=0.1)
            {
                double qX=(2*Math.Pow(t,3)-3*Math.Pow(t,2)+1)*x1 + (-2*Math.Pow(t,3)+3*Math.Pow(t,2))*x4+(Math.Pow(t,3)-2*Math.Pow(t,2)+t)*x2+(Math.Pow(t,3)-Math.Pow(t,2))*x3;
                double qY=(2 * Math.Pow(t, 3) - 3 * Math.Pow(t, 2) + 1) * y1 + (-2 * Math.Pow(t, 3) + 3 * Math.Pow(t, 2)) * y4 + (Math.Pow(t, 3) - 2 * Math.Pow(t, 2) + t) * y2 + (Math.Pow(t, 3) - Math.Pow(t, 2)) * y3;
                g.DrawLine(pen1, (float)prevX, (float)prevY, (float)qX, (float)qY);
                g.FillEllipse(new SolidBrush(Color.Black), (float)prevX - 2.5f, (float)prevY - 2.5f, 5.0f, 5.0f);
                prevX = qX;
                prevY = qY;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            double[,] tab = new double[,] { { 20.0, 20.0 }, { 20.0, 100.0 }, { 100.0, 20.0 }, { 100.0, 100.0 }, { 200, 20 }, { 200, 100 }, { 300, 20 }, { 300, 100 } };

            //double prevX = tab[4 - 3, 0] * (1) / 6 + tab[4 - 2, 0] * (4) / 6 + tab[4 - 1, 0] *
            //           (1) / 6;
            //double prevY = tab[4 - 3, 1] * (1) / 6 + tab[4 - 2, 1] * (4) / 6 + tab[4 - 1, 1] *
            //           (1) / 6;

            for (int i = 3; i < tab.GetLength(0); i++)
            {
                double prevX = tab[i - 3, 0] * (1) / 6 + tab[i - 2, 0] * (4) / 6 + tab[i - 1, 0] *
                       (1) / 6;
                double prevY = tab[i - 3, 1] * (1) / 6 + tab[i - 2, 1] * (4) / 6 + tab[i - 1, 1] *
                           (1) / 6;
                for (double t = 0.1; t < 1.0; t += 0.1)
                {
     
                    double qX = tab[i - 3, 0] * Math.Pow((1 - t),3) / 6 + tab[i - 2, 0] * (3 * Math.Pow(t, 3) - 6 * t * t + 4) / 6 + tab[i - 1, 0] *
                        (-3 * Math.Pow(t, 3) + 3 * t * t + 3 * t + 1) / 6 + tab[i, 0] * (Math.Pow(t, 3)) / 6;
                    double qY = tab[i - 3, 1] * Math.Pow((1 - t), 3) / 6 + tab[i - 2, 1] * (3 * Math.Pow(t, 3) - 6 * t * t + 4) / 6 + tab[i - 1, 1] *
                        (-3 * Math.Pow(t, 3) + 3 * t * t + 3 * t + 1) / 6 + tab[i, 1] * (Math.Pow(t, 3)) / 6;

                    g.DrawLine(pen1,(float) prevX,(float) prevY,(float) qX,(float) qY);
                   // g.FillEllipse(new SolidBrush(Color.Black), (float)prevX - 2.5f, (float)prevY - 2.5f, 5.0f, 5.0f);
                    prevX = qX;
                    prevY = qY;

                }
            }
        }
    }
}
