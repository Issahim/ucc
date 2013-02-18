using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UCC
{
    public class API
    {
        public static List<Type> Actions
        {
            get
            {
                return Global.Actions;
            }
        }

        public static List<Type> Conditions
        {
            get
            {
                return Global.Conditions;
            }
        }
    }
}
