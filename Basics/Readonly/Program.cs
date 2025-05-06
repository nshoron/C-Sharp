using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    class Program
    {
            public int x;
            //readonly 
            public readonly int y = 50;
            public readonly int z;

        public Program()
            {
                z = 80;

            }
        public Program(int r1, int r2, int r3)
        {
            x = r1;
            y = r2;
            z = r3;
        }

        static void Main(string[] args)
        {

            Program p1 = new Program(11,22,33);
            Console.WriteLine("X= "+p1.x+" Y= "+p1.y+" Z= "+p1.z);
            Program p2 = new Program();
            p2.x = 100;
            //p2.y = 30;
            Console.WriteLine("X= " + p2.x + " Y= " + p2.y + " Z= " + p2.z);
            Console.ReadLine();
        }
    }
}
