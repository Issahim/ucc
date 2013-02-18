using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UCC.Ressources
{
    public enum Moment
    {
        Combat,
        Pull,
        Patrol,
    }

    public enum ActionType
    {
        Spell,
        Special,
        Item,
    }

    public enum Unit
    {
        Target,
        Player,
        Pet,
    }

    public enum Sign
    {
        Superior,
        Egal,
        Inferior,
    }

    public enum ActionCond
    {
        Health,
        HealthPercent,
        Energy,
        EnergyPercent,
        AttackCombo,
        Buff,
        IsCasting,
        Distance,
        IsAlive,
        InCombat,
        AbilityIsUsable,
        UnitsAttackMe,
        UnitsAttackMeOnMelee,
        UnitsInMyBack,
    }

    public enum SpecialAction
    {
        ApproachMelee,
        AvoidMelee,
        GoToMelee,
        //PetAttack,
        //GoBehindTarget,
    }
}
