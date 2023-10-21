Q2) Create class library with method fact() which will return factorial of a number. Use it in console application.

namespace liib
{
    public class Class1
    {
        public int Fact(int x)
        {
            int num = 1;
            for (int i = 1; i <= x; i++)
            {
                num *= i;
            }

            return num;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            liib.Class1 c = new liib.Class1();
            int num=c.Fact(4);
            Console.WriteLine(num);
        }
    }
}

