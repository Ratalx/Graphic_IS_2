namespace Transform
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
            this.textTx = new System.Windows.Forms.TextBox();
            this.textTy = new System.Windows.Forms.TextBox();
            this.textScalY = new System.Windows.Forms.TextBox();
            this.textAlpha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textScalX = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textTx
            // 
            this.textTx.Location = new System.Drawing.Point(357, 111);
            this.textTx.Name = "textTx";
            this.textTx.Size = new System.Drawing.Size(100, 22);
            this.textTx.TabIndex = 0;
            this.textTx.Text = "-100";
            // 
            // textTy
            // 
            this.textTy.Location = new System.Drawing.Point(505, 111);
            this.textTy.Name = "textTy";
            this.textTy.Size = new System.Drawing.Size(100, 22);
            this.textTy.TabIndex = 1;
            this.textTy.Text = "-50";
            // 
            // textScalY
            // 
            this.textScalY.Location = new System.Drawing.Point(505, 247);
            this.textScalY.Name = "textScalY";
            this.textScalY.Size = new System.Drawing.Size(100, 22);
            this.textScalY.TabIndex = 2;
            // 
            // textAlpha
            // 
            this.textAlpha.Location = new System.Drawing.Point(427, 173);
            this.textAlpha.Name = "textAlpha";
            this.textAlpha.Size = new System.Drawing.Size(100, 22);
            this.textAlpha.TabIndex = 3;
            this.textAlpha.Text = "10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 370);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Spiral";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Translation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(442, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "Rotation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(442, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 8;
            this.button4.Text = "zlozony";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textScalX
            // 
            this.textScalX.Location = new System.Drawing.Point(360, 246);
            this.textScalX.Name = "textScalX";
            this.textScalX.Size = new System.Drawing.Size(100, 22);
            this.textScalX.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(442, 284);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Scala";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 495);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textScalX);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textAlpha);
            this.Controls.Add(this.textScalY);
            this.Controls.Add(this.textTy);
            this.Controls.Add(this.textTx);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTx;
        private System.Windows.Forms.TextBox textTy;
        private System.Windows.Forms.TextBox textScalY;
        private System.Windows.Forms.TextBox textAlpha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textScalX;
        private System.Windows.Forms.Button button5;
    }
}

