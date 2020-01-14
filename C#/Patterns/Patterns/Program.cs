using System;
using AbstractFactory;
using Factory_Method;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FactoryMethod

            Console.WriteLine("\nDemonstrating \"Factory Method\":");
            
            Shop shop1 = new Amazon();
            Shop shop2 = new Wallmart();

            Console.WriteLine("\nBuying cookies.");
            Cookies cookies1 = shop1.BuyCookies();
            Cookies cookies2 = shop2.BuyCookies();

            Console.WriteLine("\nEating cookies.");
            cookies1.Eat();
            cookies2.Eat();
            
            #endregion

            #region AbstractFactory

            Console.WriteLine("\nDemonstrating \"Abstract Factory\"");
            
            Console.WriteLine("\nBorn gods");
            God zeus = new God(new BornZeus());
            God poseidon = new God(new BornPoseidon());
            God aid = new God(new BornAids());
            
            Console.WriteLine("\nZeus is here");
            zeus.Weapon.Attack();
            zeus.Ability.Use();
            
            Console.WriteLine("\nPoseidon is here");
            poseidon.Weapon.Attack();
            poseidon.Ability.Use();
            
            Console.WriteLine("\nAid is here");
            aid.Weapon.Attack();
            aid.Ability.Use();

            #endregion

            Console.Write("\nPress key to continue...");
            Console.ReadLine();
        }
    }
}