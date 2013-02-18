using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UCC.Classes
{
    class Combos
    {
        static String LastSkill { get; set; }
        static int Stacks { get; set; }

        internal static void castedSkill(String skillName)
        {
            if (skillName == LastSkill)
                Stacks++;
            else
            {
                LastSkill = skillName;
                Stacks = 1;
            }
            
        }

        internal static int SkillStacks(String skillName)
        {
            if (skillName == LastSkill)
                return Stacks;
            else
                return 0;
        }

        internal static void Reset()
        {
            LastSkill = String.Empty;
            Stacks = 0;
        }
    }
}
