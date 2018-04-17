namespace Krzywe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textY1 = new System.Windows.Forms.TextBox();
            this.textX1 = new System.Windows.Forms.TextBox();
            this.textY2 = new System.Windows.Forms.TextBox();
            this.textX2 = new System.Windows.Forms.TextBox();
            this.textY3 = new System.Windows.Forms.TextBox();
            this.textX3 = new System.Windows.Forms.TextBox();
            this.textY4 = new System.Windows.Forms.TextBox();
            this.textX4 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 419);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textY1
            // 
            this.textY1.Location = new System.Drawing.Point(647, 74);
            this.textY1.Name = "textY1";
            this.textY1.Size = new System.Drawing.Size(100, 22);
            this.textY1.TabIndex = 1;
            this.textY1.Text = "0";
            // 
            // textX1
            // 
            this.textX1.Location = new System.Drawing.Point(526, 74);
            this.textX1.Name = "textX1";
            this.textX1.Size = new System.Drawing.Size(100, 22);
            this.textX1.TabIndex = 2;
            this.textX1.Text = "0";
            // 
            // textY2
            // 
            this.textY2.Location = new System.Drawing.Point(647, 128);
            this.textY2.Name = "textY2";
            this.textY2.Size = new System.Drawing.Size(100, 22);
            this.textY2.TabIndex = 3;
            this.textY2.Text = "200";
            // 
            // textX2
            // 
            this.textX2.Location = new System.Drawing.Point(526, 128);
            this.textX2.Name = "textX2";
            this.textX2.Size = new System.Drawing.Size(100, 22);
            this.textX2.TabIndex = 4;
            this.textX2.Text = "50";
            // 
            // textY3
            // 
            this.textY3.Location = new System.Drawing.Point(647, 173);
            this.textY3.Name = "textY3";
            this.textY3.Size = new System.Drawing.Size(100, 22);
            this.textY3.TabIndex = 5;
            this.textY3.Text = "50";
            // 
            // textX3
            // 
            this.textX3.Location = new System.Drawing.Point(526, 173);
            this.textX3.Name = "textX3";
            this.textX3.Size = new System.Drawing.Size(100, 22);
            this.textX3.TabIndex = 6;
            this.textX3.Text = "200";
            // 
            // textY4
            // 
            this.textY4.Location = new System.Drawing.Point(647, 218);
            this.textY4.Name = "textY4";
            this.textY4.Size = new System.Drawing.Size(100, 22);
            this.textY4.TabIndex = 7;
            this.textY4.Text = "300";
            // 
            // textX4
            // 
            this.textX4.Location = new System.Drawing.Point(526, 217);
            this.textX4.Name = "textX4";
            this.textX4.Size = new System.Drawing.Size(100, 22);
            this.textX4.TabIndex = 8;
            this.textX4.Text = "300";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(526, 351);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(659, 351);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Baziera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Hermita";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(415, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "sklejana";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 518);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textX4);
            this.Controls.Add(this.textY4);
            this.Controls.Add(this.textX3);
            this.Controls.Add(this.textY3);
            this.Controls.Add(this.textX2);
            this.Controls.Add(this.textY2);
            this.Controls.Add(this.textX1);
            this.Controls.Add(this.textY1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textY1;
        private System.Windows.Forms.TextBox textX1;
        private System.Windows.Forms.TextBox textY2;
        private System.Windows.Forms.TextBox textX2;
        private System.Windows.Forms.TextBox textY3;
        private System.Windows.Forms.TextBox textX3;
        private System.Windows.Forms.TextBox textY4;
        private System.Windows.Forms.TextBox textX4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

