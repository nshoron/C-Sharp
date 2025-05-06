using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM
{
    class Program
    {/*
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        
       
         enum WeekDays
         {
             Monday=9,
             Tuesday=3,
             Wednesday=1,
             Thursday = 6,
             Friday=3,
             Saturday=7,
             Sunday=5
         }*/
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday = 6,
            Friday,
            Saturday,
            Sunday
        }
        enum Categories
        {
            Electronics = 10,
            Furniture = 3,
            Food = 5,
            Arts = 2
        }

        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Monday);
            Console.WriteLine(WeekDays.Tuesday);
            Console.WriteLine(WeekDays.Wednesday);
            Console.WriteLine(WeekDays.Thursday);
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine(WeekDays.Saturday);
            Console.WriteLine(WeekDays.Sunday);

            Console.WriteLine((int)WeekDays.Monday);
            Console.WriteLine((int)WeekDays.Tuesday);
            Console.WriteLine((int)WeekDays.Wednesday);
            Console.WriteLine((int)WeekDays.Thursday);
            Console.WriteLine((int)WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Saturday);
            Console.WriteLine((int)WeekDays.Sunday);

            string[] value = Enum.GetNames(typeof(Categories));
            foreach(string s in value)
            {
                Console.WriteLine(s);
            }

            int[] n = (int[])Enum.GetValues(typeof(Categories));
            foreach (int x in n)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }
    }
}
