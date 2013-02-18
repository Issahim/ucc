using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UCC.Classes
{
    public class Profil
    {
        public List<Action> ActionsCombat { get; set; }
        public List<Action> ActionsPull { get; set; }
        public List<Action> ActionsPatrol { get; set; }

        public Profil()
        {
            ActionsCombat = new List<Action>();
            ActionsPull = new List<Action>();
            ActionsPatrol = new List<Action>();
        }

        public List<Action> getActionList(Ressources.Moment moment)
        {
            switch (moment)
            {
                case Ressources.Moment.Pull:
                    return ActionsPull;
                case Ressources.Moment.Patrol:
                    return ActionsPatrol;
                default:
                    return ActionsCombat;
            }
        }

        public void UpAction(Action action, Ressources.Moment moment)
        {
            int index = getActionList(moment).IndexOf(action);
            if (index - 1 >= 0)
            {
                getActionList(moment).Reverse(index - 1, 2);
            }
        }

        public void DownAction(Action action, Ressources.Moment moment)
        {
            int index = getActionList(moment).IndexOf(action);
            if (index + 1 < getActionList(moment).Count)
            {
                getActionList(moment).Reverse(index, 2);
            }
        }
    }
}
