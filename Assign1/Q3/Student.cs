Q3) Create a class student in namespace DAC and in namespace DBDA write method add in both class. In entry point call both method.


using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAC
{
    internal class Student
    {
        public void Add()
        {
            Console.WriteLine("method of Dac");
        }
        
    }
}
namespace DBDA
{
    internal class Student
    {
        public void Add()
        {
            Console.WriteLine("Method of DBDA");
        }
    }
}

namespace Course
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            DAC.Student d = new DAC.Student();
            d.Add();
            DBDA.Student c = new DBDA.Student();
            c.Add();

        }
    }
}


