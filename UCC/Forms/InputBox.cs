using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UCC.Forms
{
    public partial class InputBox : Form
    {
        private InputBox()
        {
            InitializeComponent();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {

        }

        public static String Show(String question, String title, String defaultValue)
        {
            var ib = new InputBox();
            ib.Text = title;
            ib.Question.Text = question;
            ib.Result.Text = defaultValue;
            ib.ShowDialog();
            return ib.FinalResult;
        }

        String FinalResult { get; set; }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FinalResult = Result.Text;
            Close();
        }

        private void Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                FinalResult = Result.Text;
                Close();
            }
        }

        private void InputBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            Result.Text = String.Empty;
        }
    }
}
