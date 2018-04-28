using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Transform
{
    public partial class Form1 : Form
    {
        private float transformPoints(float a,float[] matrixT )
        {
            float res = a * matrixT[0] + a * matrixT[1] + a * matrixT[2];

            return res;
        }
        private System.Drawing.Graphics g;

        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Red, 1);
        private System.Drawing.Pen pen2 = new System.Drawing.Pen(Color.Blue, 1);

        private double R = 20;
        private int n = 100;
        float midX, midY;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();

            midX = 100;
            midY = 100;
            //midX = pictureBox1.Width / 2;
            //midY = pictureBox1.Height / 2;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float tX, tY;
            float.TryParse(textTx.Text, out tX);
            float.TryParse(textTy.Text, out tY);
            float[,] matrixT = { { 1, 0, -tX },{ 0, 1, -tY },{ 0, 0, 1 } };
            float[] matrixX = { 1, 0, -tX };
            float[] matrixY = { 0, 1, -tY };
            float[] matrixZ = { 0, 0, 1 };



            double step = 2 * Math.PI / n;
            double alfa = 0;
            double R1 = 1;
            while (R1 < R)
            {
                float x1 = (float)(midX + (R1) * Math.Cos(alfa));
                float y1 = (float)(midY + (R1) * Math.Sin(alfa));
                float x2 = (float)(midX + (R1) * Math.Cos(alfa + step));
                float y2 = (float)(midX + (R1) * Math.Sin(alfa + step));
                x1 = matrixT[0, 0] * x1 + matrixT[0, 1] * y1 + matrixT[0, 2] * 1;
                y1 = matrixT[1, 0] * x1 + matrixT[1, 1] * y1 + matrixT[1, 2] * 1;
                x2 = matrixT[0, 0] * x2 + matrixT[0, 1] * y2 + matrixT[0, 2] * 1;
                y2 = matrixT[1, 0] * x2 + matrixT[1, 1] * y2 + matrixT[1, 2] * 1;

                g.DrawLine(pen2,x1,y1,x2,y2);
                alfa += step;
                R1 += 0.1; ;
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            float beta;
            float.TryParse(textAlpha.Text, out beta);
            beta =(float)(beta* Math.PI/180);
            float[,] matrixT = { {(float)(Math.Cos((double)beta)), (float)(Math.Sin((double)beta)),0 }, { (float)(-Math.Sin((double)beta)), (float)(Math.Cos((double)beta)), 0 }, { 0, 0, 1 } };



            double step = 2 * Math.PI / n;
            double alfa = 0;
            double R1 = 1;
            while (R1 < R)
            {
                float x1 = (float)(midX + (R1) * Math.Cos(alfa));
                float y1 = (float)(midY + (R1) * Math.Sin(alfa));
                float x2 = (float)(midX + (R1) * Math.Cos(alfa + step));
                float y2 = (float)(midX + (R1) * Math.Sin(alfa + step));
               float px1 = matrixT[0, 0] * x1 + matrixT[0, 1] * y1;
                float py1 =matrixT[1, 0] * x1 + matrixT[1, 1] * y1;
                float px2 = matrixT[0, 0] * x2 + matrixT[0, 1] * y2;
                float py2 = matrixT[1, 0] * x2 + matrixT[1, 1] * y2;

                g.DrawLine(pen2, px1, py1, px2, py2);
                alfa += step;
                R1 += 0.1; ;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            float beta;
            float.TryParse(textAlpha.Text, out beta);
            beta = (float)(beta * Math.PI / 180);
            float[,] matrixT2 = { { (float)(Math.Cos((double)beta)), (float)(Math.Sin((double)beta)), 0 }, { (float)(-Math.Sin((double)beta)), (float)(Math.Cos((double)beta)), 0 }, { 0, 0, 1 } };

            float tX, tY;
            float.TryParse(textTx.Text, out tX);
            float.TryParse(textTy.Text, out tY);
            float[,] matrixT1 = { { 1, 0, -tX }, { 0, 1, -tY }, { 0, 0, 1 } };
            float[] matrixX = { 1, 0, -tX };
            float[] matrixY = { 0, 1, -tY };
            float[] matrixZ = { 0, 0, 1 };



            double step = 2 * Math.PI / n;
            double alfa = 0;
            double R1 = 1;
            while (R1 < R)
            {
                float x1 = (float)(midX + (R1) * Math.Cos(alfa));
                float y1 = (float)(midY + (R1) * Math.Sin(alfa));
                float x2 = (float)(midX + (R1) * Math.Cos(alfa + step));
                float y2 = (float)(midX + (R1) * Math.Sin(alfa + step));
                x1 = matrixT1[0, 0] * x1 + matrixT1[0, 1] * y1 + matrixT1[0, 2] * 1;
                y1 = matrixT1[1, 0] * x1 + matrixT1[1, 1] * y1 + matrixT1[1, 2] * 1;
                x2 = matrixT1[0, 0] * x2 + matrixT1[0, 1] * y2 + matrixT1[0, 2] * 1;
                y2 = matrixT1[1, 0] * x2 + matrixT1[1, 1] * y2 + matrixT1[1, 2] * 1;

                float px1 = matrixT2[0, 0] * x1 + matrixT2[0, 1] * y1;
                float py1 = matrixT2[1, 0] * x1 + matrixT2[1, 1] * y1;
                float px2 = matrixT2[0, 0] * x2 + matrixT2[0, 1] * y2;
                float py2 = matrixT2[1, 0] * x2 + matrixT2[1, 1] * y2;

                g.DrawLine(pen2, px1, py1, px2, py2);
                alfa += step;
                R1 += 0.1; ;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            float tX, tY;
            float.TryParse(textScalX.Text, out tX);
            float.TryParse(textScalY.Text, out tY);
            float[,] matrixT = { {tX,0,0 }, { 0,tY,0 }, { 0, 0, 1 } };

            double step = 2 * Math.PI / n;
            double alfa = 0;
            double R1 = 1;
            while (R1 < R)
            {
                float x1 = (float)(midX + (R1) * Math.Cos(alfa));
                float y1 = (float)(midY + (R1) * Math.Sin(alfa));
                float x2 = (float)(midX + (R1) * Math.Cos(alfa + step));
                float y2 = (float)(midX + (R1) * Math.Sin(alfa + step));
                x1 =tX*x1;
                y1 =tY*y1;
                x2 = tX * x2;
                y2 =y2* tY;

                g.DrawLine(pen2, x1, y1, x2, y2);
                alfa += step;
                R1 += 0.1; ;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            double step = 2 * Math.PI / n;
            double alfa = 0;
            double R1 = 1;
            while (R1 < R)
            {

                g.DrawLine(pen1, (float)(midX + (R1) * Math.Cos(alfa)), (float)(midY + (R1) * Math.Sin(alfa)), (float)(midX + (R1) * Math.Cos(alfa + step)), (float)((midY + (R1) * Math.Sin(alfa + step))));
                alfa += step;
                R1 += 0.1; ;
            }
        }
        }
}
