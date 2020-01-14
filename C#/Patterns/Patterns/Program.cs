﻿using System;
using Factory_Method;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Factory_Method

            Shop shop1 = new Amazon();
            Shop shop2 = new Wallmart();

            Cookies cookies1 = shop1.BuyCookies();
            Cookies cookies2 = shop2.BuyCookies();

            cookies1.Eat();
            cookies2.Eat();
            
            #endregion

            Console.Write("\nPress key to continue...");
            Console.ReadLine();
        }
    }
}