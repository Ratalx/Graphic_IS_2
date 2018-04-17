using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue,2);
        private System.Drawing.Pen pen2 = new System.Drawing.Pen(Color.Red, 2);
        private System.Drawing.Pen pen3 = new System.Drawing.Pen(Color.Black, 3);
        private System.Drawing.SolidBrush brush1= new System.Drawing.SolidBrush(Color.Black);
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            float x1, x2, x3, x4, y1, y2, y3, y4;
            float.TryParse(textX1.Text, out x1);
            float.TryParse(textX2.Text, out x2);
            float.TryParse(textX3.Text, out x3);
            float.TryParse(textX4.Text, out x4);
            float.TryParse(textY1.Text, out y1);
            float.TryParse(textY2.Text, out y2);
            float.TryParse(textY3.Text, out y3);
            float.TryParse(textY4.Text, out y4);
            float delta = (x2 - x1) * (y3 - y4) - (x3 - x4)*(y2 - y1);
            if (delta == 0)
            {
                g.DrawLine(pen1, x1, y1, x2, y2);
                g.DrawLine(pen2, x3, y3, x4, y4);
            }
            else
            {
                float deltaU = (x3 - x1) * (y3 - y4) - (x3 - x4) * (y3 - y1);
                float u = deltaU / delta;
                float crossX = (1 - u) * x1 + u * x2;
                float crossY = (1 - u) * y1 + u * y2;
                g.DrawLine(pen1, x1, y1, x2, y2);
                g.DrawLine(pen2, x3, y3, x4, y4);
                g.DrawEllipse(pen3, crossX-2.5f, crossY-2.5f, 5f, 5f);
                g.FillEllipse(brush1, crossX-2.5f, crossY-2.5f, 5f, 5f);
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            double c, d, a, b;
            Double.TryParse(textX1.Text, out a);
            Double.TryParse(textX2.Text, out c);
            Double.TryParse(textY1.Text, out b);
            Double.TryParse(textY2.Text, out d);
            //double a=Math.Sqrt(3.0)/2.0;
            //double b = (1.0 / 2.0);
            //double c = (-1.0 / 2.0);
            //double d = -Math.Sqrt(3.0) / 2.0;
            double res = a * c + b * d;
            res = Math.Abs(res);
            Angle.Text = (Math.Acos(res)*180/Math.PI).ToString();
            g.DrawPie(pen1, 100, 100, 100, 100, 0, (float)(-res*180/Math.PI));
        }
    }
}
