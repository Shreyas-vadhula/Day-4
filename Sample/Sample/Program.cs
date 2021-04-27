using System;

namespace Sample7
{
    class Program
    {
        class Class7
        {
            public int a;
            public int b;

            public void InputX()
            {
                Console.WriteLine("Enter a number, a=");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number, b=");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sum = " + (a + b));

            }
            public static void Main()
            {
                Class7 obj = new Class7();
                //int exitkey = 1;
                for (; ; )
                {
                    Console.WriteLine("You want to exit ? Y/N");
                    string choice = Console.ReadLine();
                    if (choice.ToLower() == "n")
                    {
                        obj.InputX();
                        choice = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                Console.ReadLine();
            }
        }
    }
