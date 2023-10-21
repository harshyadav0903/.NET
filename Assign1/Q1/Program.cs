Q1) Create class calculator with two method Add and product. Create object and call method

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Program
    {
        public int Add(int x, int y)
        {
            return x + y;

        }
        public int Multi(int x,int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            int b=a.Add(2,3);
            Console.WriteLine(b);
            Program c = new Program();
            int d=c.Multi(1,3);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
