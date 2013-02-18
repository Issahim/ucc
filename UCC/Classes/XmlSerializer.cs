using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace UCC.Classes
{
    public class XmlSerializer
    {
        static List<Type> extraTypes
        {
            get
            {
                var types = new List<Type>();
                types.AddRange(Global.Actions);
                types.AddRange(Global.Conditions);
                return types;
            }
        }

        public static Boolean Serialize(String Path, object Object)
        {

            FileStream fs = null;

            try
            {
                File.Delete(Path);
            }
            catch { }

            try
            {
                fs = new FileStream(Path, FileMode.Create);
                System.Xml.Serialization.XmlSerializer s = new System.Xml.Serialization.XmlSerializer(Object.GetType(), extraTypes.ToArray());
                s.Serialize(fs, Object);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }

            return fs != null;

        }

        public static T Deserialize<T>(String Path)
        {

            T Result = Activator.CreateInstance<T>();

            FileStream fs = null;

            try
            {
                fs = new FileStream(Path, FileMode.Open);
                System.Xml.Serialization.XmlSerializer s = new System.Xml.Serialization.XmlSerializer(typeof(T), extraTypes.ToArray());
                Result = (T)s.Deserialize(fs);
                fs.Close();
                return Result;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }

            return Result;

        }

    }

}
