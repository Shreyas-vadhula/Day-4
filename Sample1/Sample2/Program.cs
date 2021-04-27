using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample3;

namespace Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cal = new Class1();
            Console.WriteLine(cal.Sum(5, 6));
            Console.WriteLine(cal.Sub(5, 6));
            Console.WriteLine(cal.Div(5, 6));
            Console.WriteLine(cal.Product(5, 6));
            Console.ReadLine();
        }
    }
    }
}
