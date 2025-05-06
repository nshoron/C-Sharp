using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            ///String from Constructor
            char[] chars = { 'C', 'e', 'c', 'i', 'l', 'i', 'a' };
            string name = new string(chars);
            Console.WriteLine(name);
            /// String from Literal
            string fname = "Cecilia";
            string lname = "Hansen";
            string age = "25";
            /*
            Console.WriteLine("First Name : {0}",fname);
            Console.WriteLine("Last Name  : {0}", lname);
            Console.WriteLine("Age        : {0}", age);
            */
            Console.WriteLine("First Name : "+ fname);
            Console.WriteLine("Last Name  : "+ lname);
            Console.WriteLine("Age        : "+ age);

            string now = "Date : " + DateTime.Now.ToString("D");
            Console.WriteLine(now);
            now = "Date : " + DateTime.Now.ToString("MM-dd-yy");
            Console.WriteLine(now);
            now = "Date : " + DateTime.Now.ToString("hh:mm:ss");
            Console.WriteLine(now);
            now = "Date : " + DateTime.Now.ToString();
            Console.WriteLine(now);

            string Info = "Cecilia Hansen is 25 years old";
            int start = Info.IndexOf("is") + 1;
            Console.WriteLine(start);//16
            string substring = Info.Substring(start + 2, 2);
            //string substring = Info.Substring(0, 6);// 0<=x<6
            Console.WriteLine("Age is "+ substring);
            for(int count=0;count<=Info.Length-1;count++)
            {
                Console.Write(Info[count]);
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
