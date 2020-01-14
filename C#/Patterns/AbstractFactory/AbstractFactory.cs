using System;

namespace AbstractFactory
{
    #region Client

    public class God
    {
        public Weapon Weapon;
        public Ability Ability;

        public God(GodsBorn godsBorn)
        {
            Weapon = godsBorn.CreateWeapon();
            Ability = godsBorn.CreateAbility();
        }
    }

    #endregion

    #region Factory

    public abstract class Weapon
    {
        public abstract void Attack();
    }

    public abstract class Ability
    {
        public abstract void Use();
    }

    public abstract class GodsBorn
    {
        public abstract Weapon CreateWeapon();
        public abstract Ability CreateAbility();
    }
    
    #endregion

    #region Product

    public class LightningBolt : Weapon
    {
        public override void Attack()
        {
           Console.WriteLine("Zip-zap"); 
        }
    }

    public class Trident : Weapon
    {
        public override void Attack()
        {
           Console.WriteLine("One hit - three holes"); 
        }
    }

    public class Spell : Weapon
    {
        public override void Attack()
        {
           Console.WriteLine("Diddly doodles"); 
        }
    }

    public class LordOfTheGods : Ability
    {
        public override void Use()
        {
           Console.WriteLine("All gods kneel in front of you"); 
        }
    }
    
    public class LordOfTheSea : Ability
    {
        public override void Use()
        {
           Console.WriteLine("Fishes are talk to you"); 
        }
    }

    public class LordOfTheHell : Ability
    {
        public override void Use()
        {
           Console.WriteLine("Death is your maiden"); 
        }
    }

    public class BornZeus:GodsBorn
    {
        public override Weapon CreateWeapon()
        {
            return new LightningBolt();
        }

        public override Ability CreateAbility()
        {
           return new LordOfTheGods();
        }
    }

    public class BornPoseidon : GodsBorn
    {
        public override Weapon CreateWeapon()
        {
           return new Trident();
        }

        public override Ability CreateAbility()
        {
            return new LordOfTheSea();
        }
    }
    public class BornAids: GodsBorn
    {
        public override Weapon CreateWeapon()
        {
           return new Spell();
        }

        public override Ability CreateAbility()
        {
            return new LordOfTheHell();
        }
    }

    #endregion
}