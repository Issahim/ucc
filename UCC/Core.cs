using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UCC
{
    public class Core
    {
        public Classes.Profil mProfil { get; set; }

        public Core()
        {
            mProfil = new Classes.Profil();
        }

        public void Run(Ressources.Moment moment)
        {
            try
            {
                switch (moment)
                {
                    case Ressources.Moment.Pull:
                        new Classes.ActionsPlayer(mProfil.ActionsPull).playActionList();
                        break;
                    case Ressources.Moment.Patrol:
                        new Classes.ActionsPlayer(mProfil.ActionsPatrol).playActionList();
                        break;
                    default:
                        new Classes.ActionsPlayer(mProfil.ActionsCombat).playActionList(true, false);
                        break;
                }
            }
            catch (Exception e)
            {
            }

        }
    }
}
