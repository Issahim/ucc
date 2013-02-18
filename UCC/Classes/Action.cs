using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace UCC.Classes
{
    public abstract class Action
    {
        [DisplayName("Name"), Description("Name of the action in ucc profil."), Category("1. Main")]
        public String ActionName { get; set; }

        [Browsable(false)]
        public List<Condition> Conditions { get; set; }

        [DisplayName("Timer (ms)"), Description("Set a pause just after the action."), Category("Advanced (Optionnal)")]
        public int Timer { get; set; }
        [XmlIgnore, Browsable(false)]
        public Timeout CurrentTimeout { get; set; }
        [XmlIgnore, DisplayName("Enabled"), Description("Enable or disable this action."), Category("Advanced (Optionnal)")]
        public Boolean Enabled { get; set; }
        [DisplayName("Only one condition must be good"), Description("Only one condition must be good, except \"Can't be ignored\" conditions."), Category("Advanced (Optionnal)")]
        public Boolean OneCondMustGood { get; set; }

        protected Action()
        {
            ActionName = "New Action";
            Conditions = new List<Condition>();
            Timer = 0;
            Enabled = true;
        }

        /// <summary>
        /// Use to copy base properties.
        /// </summary>
        /// <param name="newAct">New action</param>
        /// <returns></returns>
        protected Action BaseClone(Action newAct)
        {
            newAct.ActionName = ActionName;
            newAct.Timer = Timer;
            newAct.Enabled = Enabled;
            foreach (var cond in Conditions)
            {
                newAct.Conditions.Add(cond.Clone());
            }
            return newAct;
        }

        public abstract Action Clone();

        public override string ToString()
        {
            return ActionName;
        }

        [XmlIgnore, Browsable(false)]
        public abstract Boolean NeedToRun { get; }

        public abstract Boolean Run();
        
    }
}
