namespace UCC.Forms
{
    partial class InputBox
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
            this.Question = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(12, 9);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(49, 13);
            this.Question.TabIndex = 0;
            this.Question.Text = "Question";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(15, 27);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(212, 20);
            this.Result.TabIndex = 1;
            this.Result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Result_KeyPress);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(231, 26);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(41, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 58);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputBox";
            this.Text = "InputBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputBox_FormClosing);
            this.Load += new System.EventHandler(this.InputBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button buttonOK;
    }
}