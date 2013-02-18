namespace UCC.Forms
{
    partial class Algo
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
            this.kryptonHeaderGroup1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonPanel1 = new System.Windows.Forms.Panel();
            this.BClose = new System.Windows.Forms.Button();
            this.kryptonPanel2 = new System.Windows.Forms.Panel();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Controls.Add(this.kryptonPanel2);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(465, 561);
            this.kryptonHeaderGroup1.TabIndex = 1;
            this.kryptonHeaderGroup1.Text = "UCC Operation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::UCC.Properties.Resources.uccalgo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 487);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonHeaderGroup1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(465, 561);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(185, 497);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(90, 25);
            this.BClose.TabIndex = 2;
            this.BClose.Text = "Close";
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.pictureBox1);
            this.kryptonPanel2.Controls.Add(this.BClose);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(463, 529);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // Algo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 561);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Algo";
            this.Load += new System.EventHandler(this.Algo_Load);

        }

        #endregion

        private System.Windows.Forms.GroupBox kryptonHeaderGroup1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel kryptonPanel1;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Panel kryptonPanel2;

    }
}