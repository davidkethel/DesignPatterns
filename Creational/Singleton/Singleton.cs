using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
   public sealed class Singleton
   {

       private static Singleton _instance = null;

       private Singleton(){}

       public static Singleton Instance
       {
           get { return _instance ?? (_instance = new Singleton()); }
       }
   }
}
