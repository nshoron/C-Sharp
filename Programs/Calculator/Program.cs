using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInterface
{
    public interface BasicCalculatorInterface
    {
        int Sum(int x, int y);
        int Sub(int x, int y);
        int Multiplication(int x, int y);
        int Division(int x, int y);
    }

    public interface ScientificCalculatorInterface
    {
        int XtoY(int x, int y);
    }

    public class Calculator : BasicCalculatorInterface, ScientificCalculatorInterface
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        public int Division(int x, int y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }

        public int XtoY(int x, int y)
        {
 
            return (int)Math.Pow(x, y);
        }
    
    }
    public static void Main (String[]args)
    {
        Calculator c1 = new Calculator();
        c1.Sum(5,5);


    }

}
