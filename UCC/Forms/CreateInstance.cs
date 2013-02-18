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
    public partial class CreateInstance : Form
    {
        private CreateInstance()
        {
            InitializeComponent();
        }

        new public static object Show(Type baseType, List<Type> types)
        {
            if (types.Count == 0)
                return null;
            var form = new CreateInstance();
            form.Text = "Create new " + baseType.Name;
            foreach (var type in types)
            {
                if (type.BaseType == baseType)
                    form.typesList.Items.Add(type.Name);
            }
            form.typesList.SelectedIndex = 0;
            form.ShowDialog();
            if (!form.valid)
                return null;
            Type selectedType = null;
            foreach (var type in types)
            {
                if (form.typesList.SelectedItem.ToString() == type.Name)
                {
                    selectedType = type;
                    break;
                }
            }
            return System.Activator.CreateInstance(selectedType);
        }

        private void CreateInstance_Load(object sender, EventArgs e)
        {

        }

        Boolean valid = false;
        private void btnOK_Click(object sender, EventArgs e)
        {
            valid = true;
            Close();
        }
    }
}
