using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAR
{
    class Program
    {
        static void Main(string[] args)
        {
            // int value
            var age = 45;
            Console.WriteLine("Var can hold int values : "+age);
            // string value
            var name = "Cecilia Hansen";
            Console.WriteLine("Var can hold string values : " + name);
            /// Array
            var odds = new[] { 1, 3, 5, 7, 9 };
            Console.WriteLine("Var can hold an array .");
            foreach(var num in odds)
            {
                Console.WriteLine(num);
            }
            //for loop
            for(var x =1; x<=10;x++)
            {
                Console.WriteLine("Proud AIUBIAN");
            }

            var p = 10; //Valid
            //var q;
            //q = 10;
            //var r = null//Invalid
            Console.ReadLine();
        }
    }
}
