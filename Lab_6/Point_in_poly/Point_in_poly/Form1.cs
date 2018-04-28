using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_in_poly
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new Pen(Color.Blue, 4);
        private System.Drawing.Pen pen2 = new Pen(Color.IndianRed, 4);
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();

        }
        private void drawPoint(double x, double y, Color c)
        {
            System.Drawing.Pen tempPen = new Pen(c);
            SolidBrush tempBrush = new SolidBrush(c);
            g.DrawEllipse(tempPen, (float)x, (float)y, 4, 4);
            g.FillEllipse(tempBrush, (float)x, (float)y, 4, 4);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            double rx, ry, px1, px2, py2, py1;
            double.TryParse(textP1X.Text, out rx);
            double.TryParse(textP1Y.Text, out ry);

            double.TryParse(textX1.Text, out px1);
            double.TryParse(textX2.Text, out px2);

            double.TryParse(textY1.Text, out py1);
            double.TryParse(textY2.Text, out py2);

            //  g.FillEllipse(new SolidBrush(Color.Black),(float)p1x,(float) p1y, 10, 10);
            drawPoint(rx, ry, Color.Black);
            g.DrawLine(pen1, (float)px1, (float)py1, (float)px2, (float)py2);
            var def = pointsAndLine(px1, py1, px2, py2, rx, ry);
            if (def > 0)
            {
                label1.Text = "Right";
            }
            else if (def < 0)
            {
                label1.Text = "Left";
            }
            else
            {
                label1.Text = "Inside";
            }
        }
        private double defOfMatrix(double[,] matrix)
        {
            double res = 0;

            res = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] + matrix[0, 2] * matrix[1, 0] * matrix[2, 1] - matrix[0, 2] * matrix[1, 1] * matrix[2, 0] - matrix[0, 1] * matrix[1, 0] * matrix[2, 2] - matrix[0, 0] * matrix[1, 2] * matrix[2, 1];

            return res;
        }
        private double pointsAndLine(double px1, double py1, double px2, double py2, double rx, double ry)
        {
            double def = 0;

            double[,] matrix = { { px1, py1, 1 }, { px2, py2, 1 }, { rx, ry, 1 } };
            def = defOfMatrix(matrix);

            return def;
        }
        private void textP1Y_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            double rx1, ry1, px1, px2, py2, py1, rx2, ry2;
            double.TryParse(textP1X.Text, out rx1);
            double.TryParse(textP1Y.Text, out ry1);
            double.TryParse(textP2X.Text, out rx2);
            double.TryParse(textP2Y.Text, out ry2);




            double.TryParse(textX1.Text, out px1);
            double.TryParse(textX2.Text, out px2);

            double.TryParse(textY1.Text, out py1);
            double.TryParse(textY2.Text, out py2);

            //  g.FillEllipse(new SolidBrush(Color.Black),(float)p1x,(float) p1y, 10, 10);
            drawPoint(rx1, ry1, Color.Black);
            drawPoint(rx2, ry2, Color.Red);

            g.DrawLine(pen1, (float)px1, (float)py1, (float)px2, (float)py2);
            var def1 = pointsAndLine(px1, py1, px2, py2, rx1, ry1);
            var def2 = pointsAndLine(px1, py1, px2, py2, rx2, ry2);
            if (def1 * def2 > 0)
            {
                label2.Text = "Same Side";
            }
            else if (def1 * def2 < 0)
            {
                label2.Text = "Other Side";

            }
            else
            {
                label2.Text = "One of them is inside";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            double rx1, ry1, px1, px2, py2, py1, rx2, ry2;
            double.TryParse(textP1X.Text, out rx1);
            double.TryParse(textP1Y.Text, out ry1);
            double.TryParse(textP2X.Text, out rx2);
            double.TryParse(textP2Y.Text, out ry2);




            double.TryParse(textX1.Text, out px1);
            double.TryParse(textX2.Text, out px2);

            double.TryParse(textY1.Text, out py1);
            double.TryParse(textY2.Text, out py2);

            //  g.FillEllipse(new SolidBrush(Color.Black),(float)p1x,(float) p1y, 10, 10);
            //drawPoint(rx1, ry1, Color.Black);
            //drawPoint(rx2, ry2, Color.Red);
            g.DrawLine(pen2, (float)rx1, (float)ry1, (float)rx2, (float)ry2);
            g.DrawLine(pen1, (float)px1, (float)py1, (float)px2, (float)py2);
            var def1 = pointsAndLine(px1, py1, px2, py2, rx1, ry1);
            var def2 = pointsAndLine(px1, py1, px2, py2, rx2, ry2);
            var def3 = pointsAndLine(rx1, ry1, rx2, ry2, px1, py1);
            var def4 = pointsAndLine(rx1, ry1, rx2, ry2, px2, py2);
            var cross = TheyCross(px1, py1, px2, py2, rx1, ry1, rx2, ry2);
            if (cross)
            {
                label2.Text = "They cross ";

            }
            else
            {
                label2.Text = "They not cross";
            }
        }
        private bool TheyCross(double px1, double py1, double px2, double py2, double rx1, double ry1, double rx2, double ry2)
        {
            var def1 = pointsAndLine(px1, py1, px2, py2, rx1, ry1);
            var def2 = pointsAndLine(px1, py1, px2, py2, rx2, ry2);
            var def3 = pointsAndLine(rx1, ry1, rx2, ry2, px1, py1);
            var def4 = pointsAndLine(rx1, ry1, rx2, ry2, px2, py2);

            if (def1 * def2 <= 0 && def3 * def4 <= 0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            double rx1, ry1;
            double.TryParse(textP1X.Text, out rx1);
            double.TryParse(textP1Y.Text, out ry1);
            //drawPoint(rx1, ry1, Color.Black);
            g.Clear(Color.White);
            Point[] p = { new Point(50, 50), new Point(150, 50), new Point(150, 150), new Point(100, 70), new Point(70, 100), new Point(65, 65), new Point(50, 120), };
            g.DrawPolygon(pen1, p);
            drawPoint(rx1, ry1, Color.Black);
            int res = 0;
            for (int i = 1; i < p.Length; ++i)
            {
                if (TheyCross(p[i].X, p[i].Y, p[i - 1].X, p[i - 1].Y, -100, -100, rx1, ry1))
                {
                    ++res;
                }
            }
            if (res % 2 == 0)
            {
                label3.Text = "Poza";
            }
            else
            {
                label3.Text = "w srodku";
            }
        }
    }
}
