using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UCC.Classes
{
    class ActionsPlayer
    {
        public List<Action> actions { get; set; }

        public ActionsPlayer(List<Action> pActions)
        {
            actions = pActions;
        }

        public int playActionList(Boolean breakOnAction = false, Boolean waitSpell = true)
        {
            int playedActions = 0;
            foreach (var action in actions)
            {
                //My.Logger.WriteLine(action.actionName + " " + action.disabled);
                if (action.NeedToRun)
                {
                    if (action.Run())
                    {
                        playedActions++;

                        if (breakOnAction)
                            break;
                        else
                            System.Threading.Thread.Sleep(1000);
                    }
                }
            }
            return playedActions;
        }
    }
}
