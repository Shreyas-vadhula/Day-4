using System;

namespace Sample8
{
    class MyException : ApplicationException
    {
        public void MyNullException()
        {
            Console.WriteLine("Exception Occured, Object is null ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program c=null;
            try
            {
                if(c==null)
                {
                    throw new MyException();
                }
            }
            catch(MyException ex)
            {
                ex.MyNullException();
            }
            Console.ReadLine();
        }
    }
}