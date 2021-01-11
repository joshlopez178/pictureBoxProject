namespace pictureBoxProject
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.btnShow3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(601, 98);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(99, 37);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "picture1";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnShow2
            // 
            this.btnShow2.Location = new System.Drawing.Point(601, 177);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(99, 37);
            this.btnShow2.TabIndex = 2;
            this.btnShow2.Text = "picture2";
            this.btnShow2.UseVisualStyleBackColor = true;
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // btnShow3
            // 
            this.btnShow3.Location = new System.Drawing.Point(601, 259);
            this.btnShow3.Name = "btnShow3";
            this.btnShow3.Size = new System.Drawing.Size(99, 36);
            this.btnShow3.TabIndex = 3;
            this.btnShow3.Text = "picture3";
            this.btnShow3.UseVisualStyleBackColor = true;
            this.btnShow3.Click += new System.EventHandler(this.btnShow3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 360);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click any button to display an image!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow3);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "picutreBoxProject";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.Button btnShow3;
        private System.Windows.Forms.Label label1;
    }
}

