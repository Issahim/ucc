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
    public partial class Algo : Form
    {
        private Algo()
        {
            InitializeComponent();
        }

        new public static void Show()
        {
            var form = new Algo();
            form.ShowDialog();
        }

        private void Algo_Load(object sender, EventArgs e)
        {

        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
