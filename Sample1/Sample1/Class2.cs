using System;
using System.Collections.Generic;
using System.Text;
using Sample1;

namespace Sample1
{
    class Class2
    {
        public static void Main()
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
