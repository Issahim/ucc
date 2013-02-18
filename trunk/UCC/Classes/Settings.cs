using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace UCC.Classes
{
    public class Settings
    {
        public String lastCCPath = "";

        public static void load()
        {
            try
            {
                if (File.Exists(Global.confPath + @"\UCC\UCC.xml"))
                    Global.settings = XmlSerializer.Deserialize<Settings>(Global.confPath + @"\UCC\UCC.xml");
            }
            catch { }
        }

        public static void save()
        {
            try
            {
                XmlSerializer.Serialize(Global.confPath + @"\UCC\UCC.xml", Global.settings);
            }
            catch
            {
                MessageBox.Show("Save error !");
            }
        }
    }
}
