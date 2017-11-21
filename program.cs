/// Eliminating characters in a string having multiple occurences


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dadagiri_Logic
{
   public class Program
    {
       public static void Main(string[] args)
       {
           /// user input
           string a = Console.ReadLine();

           /// good practise
           while (a.Length > 0)
           {
               /// itearting through the loop
               for (int i = 0; i < a.Length; i++)
               {
                   string x = a[i].ToString();
                   /// avoiding the spaces
                   if (x != " ")
                   {
                       if (a.Count(p => p.ToString() == x) > 1)
                       {
                           a = a.Replace(x, string.Empty);
                       }
                   }
               }
               Console.WriteLine(a);
               Console.ReadKey();
           }
       }
    }
}
