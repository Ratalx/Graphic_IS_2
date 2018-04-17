using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProsteAlgorytymyGraficzne
{
    public partial class Form1 : Form
    {
        private double R=120;
        private int n=100;
        float midX,midY;
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Red, 1);
        private System.Drawing.Pen pen2 = new System.Drawing.Pen(Color.Green, 1);
        private System.Drawing.Pen pen3 = new System.Drawing.Pen(Color.Blue, 1);
        private System.Drawing.Pen pen4 = new System.Drawing.Pen(Color.Black, 1);

        public Form1()
        {
            InitializeComponent();
            g = pictureBox2.CreateGraphics();
            
            midX = pictureBox2.Width / 2;
            midY = pictureBox2.Height / 2;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(textBox1.Text, out R);
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            pictureBox2.Refresh();
            double step = 3.6f;
            double alfa = 0;

                for (int i = 0; i < n; i++)
                {

                    g.DrawLine(pen1, (float)(midX + (R) * Math.Cos(alfa)), (float)(midY + (R) * Math.Sin(alfa)), (float)(midX + (R) * Math.Cos(alfa + step)), (float)((midY + (R) * Math.Sin(alfa + step))));
                    alfa += step;
                }
                
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
            double R2=20;
            double R1 = 50;
            double step = 2 * Math.PI / n;
            double alfa = 0;
            for (int j =0;j<3;j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    double TempR = R2;
                    R2 = R1;
                    R1 = TempR;

                    for (int i = 0; i <= n; i++)
                    {

                        g.DrawLine(pen1, (float)(midX + (R1) * Math.Cos(alfa)), (float)(midY + (R2) * Math.Sin(alfa)), (float)(midX + (R1) * Math.Cos(alfa + step)), (float)((midY + (R2) * Math.Sin(alfa + step))));
                        alfa += step;
                    }
                }
                R1+=25;
                R2+=30;
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
            double step = 2 * Math.PI / n;
            double alfa = 0;
            double R1 = 1;
            while(R1<R)
            {

                g.DrawLine(pen1, (float)(midX + (R1) * Math.Cos(alfa)), (float)(midY + (R1) * Math.Sin(alfa)), (float)(midX + (R1) * Math.Cos(alfa + step)), (float)((midY + (R1) * Math.Sin(alfa + step))));
                alfa += step;
                R1 += 0.1; ;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
            double step = (2*Math.PI/ n);
            double beta =   Math.PI;
            double alfa = 0;
            double R1 = 0;
            while (R1 < R)
            {
               g.DrawLine(pen1, (float)(midX + (R1) * Math.Cos(alfa)), (float)(midY + (R1) * Math.Sin(beta)), (float)(midX + (R1) * Math.Cos(alfa + step)), (float)((midY + (R1) * Math.Sin(beta + step))));
               g.DrawLine(pen1, (float)(midX + (-R1) * Math.Cos(alfa)), (float)(midY + (-R1) * Math.Sin(beta)), (float)(midX + (-R1) * Math.Cos(alfa+ step)), (float)((midY + (-R1) * Math.Sin(beta+step))));
               g.DrawLine(pen1, (float)(midX + (R1) * Math.Sin(alfa)), (float)(midY +  (R1) * Math.Cos(alfa)), (float)(midX +(R1) * Math.Sin(alfa + step)), (float)((midY + (R1) * Math.Cos(alfa + step))));
               g.DrawLine(pen1, (float)(midX + (-R1) * Math.Sin(alfa)), (float)(midY + (-R1) * Math.Cos(alfa)), (float)(midX + (-R1) * Math.Sin(alfa + step)), (float)((midY + (-R1) * Math.Cos(alfa + step))));
                beta += step;
                alfa += step;
                R1 += 0.5;
                
            }
            for (int i = 0; i <= n; i++)
            {

                g.DrawLine(pen1, (float)(midX + (R) * Math.Cos(alfa)), (float)(midY + (R) * Math.Sin(alfa)), (float)(midX + (R) * Math.Cos(alfa + step)), (float)((midY + (R) * Math.Sin(alfa + step))));
                alfa += step;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
            double R2 = 20;
            double R1 = 100;
            double step = 2 * Math.PI / n;
            double step2 = 2 * Math.PI / (n / 2);
            double alfa = 0;
            double beta = 0;
            for (int j = 0; j < 10; j++)
            {
                
                 

                    for (int i = 0; i <= n; i++)
                    {

                        g.DrawLine(pen1, (float)(midX + (R1) * Math.Cos(beta)), (float)(midY + (R2) * Math.Sin(alfa)), (float)(midX + (R1) * Math.Cos(beta + step)), (float)((midY + (R2) * Math.Sin(alfa + step))));
                        g.DrawLine(pen1, (float)(midX + (R2) * Math.Cos(alfa)), (float)(midY + (R1) * Math.Sin(beta)), (float)(midX + (R2) * Math.Cos(alfa + step)), (float)((midY + (R1) * Math.Sin(beta + step2))));
                        beta += step2;
                        alfa += step;
                    }
                    
                
                

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
            double step = 2 * Math.PI / n;
            double alfa = 0;
            for (int i = 0; i <= n; i++)
            {
               
                g.DrawLine(pen1, (float)(midX +( R) * Math.Cos(alfa)), (float)(midY +( R) * Math.Sin(alfa)), (float)(midX + (R) * Math.Cos(alfa + step)), (float)((midY + (R) * Math.Sin(alfa + step))));
                alfa += step;
            }
        }
    }
}
