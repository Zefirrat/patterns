using System;

namespace Factory_Method
{
    
    #region Creator

    public abstract class Shop
    {
        public abstract Cookies BuyCookies();
    }

    public class Amazon : Shop
    {
        public override Cookies BuyCookies()
        {
            return new ChocoPie();
        }
    }

    public class Wallmart : Shop
    {
        public override Cookies BuyCookies()
        {
          return new Oreo();
        }
    }
    
    #endregion

    #region Product

    public abstract class Cookies
    {
        public string Name;
        public bool IsYummy;

        public void Eat()
        {
            string message;
            message = $"Eating {Name}.";
            if (IsYummy)
                message += " Yummy!";
            else
                message += " You are a fool if you love it...";
            Console.WriteLine(message);
        }
    }

    public class Oreo : Cookies
    {
        public Oreo()
        {
            Name = "Oreo";
            IsYummy = false;
        }
    }

    public class ChocoPie : Cookies
    {
        public ChocoPie()
        {
            Name = "ChocoPie";
            IsYummy = true;
        }
    }

    #endregion
    
}