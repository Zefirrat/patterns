using System;

namespace Singleton
{
   public class ResourcesCounter
   {
      public static ResourcesCounter GetInstance()
      {
         return _instanse;
      }

      public int Gold;
      public int Wood;

      private static ResourcesCounter _instanse = new ResourcesCounter();
      
      private ResourcesCounter()
      {
         Random rnd = new Random();
         Gold = rnd.Next();
         Wood = rnd.Next();
      }
   }
}