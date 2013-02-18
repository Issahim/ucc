using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UCC
{
    class Global
    {
        public static Classes.Settings settings = new Classes.Settings();
        public static String confPath = string.Empty;
        public static List<Type> Actions = new List<Type>();
        public static List<Type> Conditions = new List<Type>();
    }
}
