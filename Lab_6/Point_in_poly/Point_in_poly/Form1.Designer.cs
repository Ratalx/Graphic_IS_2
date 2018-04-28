namespace Point_in_poly
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
            this.textX1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textY1 = new System.Windows.Forms.TextBox();
            this.textX2 = new System.Windows.Forms.TextBox();
            this.textY2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textP1X = new System.Windows.Forms.TextBox();
            this.textP1Y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textP2X = new System.Windows.Forms.TextBox();
            this.textP2Y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textX1
            // 
            this.textX1.Location = new System.Drawing.Point(573, 53);
            this.textX1.Name = "textX1";
            this.textX1.Size = new System.Drawing.Size(100, 22);
            this.textX1.TabIndex = 0;
            this.textX1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "pierwsze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textY1
            // 
            this.textY1.Location = new System.Drawing.Point(715, 52);
            this.textY1.Name = "textY1";
            this.textY1.Size = new System.Drawing.Size(100, 22);
            this.textY1.TabIndex = 2;
            this.textY1.Text = "0";
            // 
            // textX2
            // 
            this.textX2.Location = new System.Drawing.Point(573, 82);
            this.textX2.Name = "textX2";
            this.textX2.Size = new System.Drawing.Size(100, 22);
            this.textX2.TabIndex = 3;
            this.textX2.Text = "100";
            // 
            // textY2
            // 
            this.textY2.Location = new System.Drawing.Point(715, 81);
            this.textY2.Name = "textY2";
            this.textY2.Size = new System.Drawing.Size(100, 22);
            this.textY2.TabIndex = 4;
            this.textY2.Text = "100";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 367);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textP1X
            // 
            this.textP1X.Location = new System.Drawing.Point(573, 133);
            this.textP1X.Name = "textP1X";
            this.textP1X.Size = new System.Drawing.Size(100, 22);
            this.textP1X.TabIndex = 6;
            this.textP1X.Text = "100";
            // 
            // textP1Y
            // 
            this.textP1Y.Location = new System.Drawing.Point(715, 133);
            this.textP1Y.Name = "textP1Y";
            this.textP1Y.Size = new System.Drawing.Size(100, 22);
            this.textP1Y.TabIndex = 7;
            this.textP1Y.Text = "20";
            this.textP1Y.TextChanged += new System.EventHandler(this.textP1Y_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Strona";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Po tej samej stronie ?";
            // 
            // textP2X
            // 
            this.textP2X.Location = new System.Drawing.Point(573, 174);
            this.textP2X.Name = "textP2X";
            this.textP2X.Size = new System.Drawing.Size(100, 22);
            this.textP2X.TabIndex = 11;
            this.textP2X.Text = "20";
            // 
            // textP2Y
            // 
            this.textP2Y.Location = new System.Drawing.Point(715, 173);
            this.textP2Y.Name = "textP2Y";
            this.textP2Y.Size = new System.Drawing.Size(100, 22);
            this.textP2Y.TabIndex = 12;
            this.textP2Y.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Przecinają sie ?";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(715, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 46);
            this.button3.TabIndex = 14;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(589, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 15;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 512);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textP2Y);
            this.Controls.Add(this.textP2X);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textP1Y);
            this.Controls.Add(this.textP1X);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textY2);
            this.Controls.Add(this.textX2);
            this.Controls.Add(this.textY1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textX1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textX1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textY1;
        private System.Windows.Forms.TextBox textX2;
        private System.Windows.Forms.TextBox textY2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textP1X;
        private System.Windows.Forms.TextBox textP1Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textP2X;
        private System.Windows.Forms.TextBox textP2Y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

