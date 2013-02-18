using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace UCC.Classes
{
    public abstract class Condition
    {
        [DisplayName("Locked"), Description("If Only one condition must be good is enabled for action, this condition can't be ignored."), Category("Advanced (Optionnal)")]
        public Boolean Locked { get; set; }

        public Condition()
        {
            Locked = false;
        }

        /// <summary>
        /// Use to copy base properties.
        /// </summary>
        /// <param name="newCond">New condition</param>
        /// <returns></returns>
        protected Condition BaseClone(Condition newCond)
        {
            newCond.Locked = Locked;
            return newCond;
        }

        public abstract Condition Clone();

        public override string ToString()
        {
            return base.GetType().Name;
        }

        [XmlIgnore, Browsable(false)]
        public abstract Boolean IsOK { get; }
    }
}
