using System;

namespace Sample9
{
    class Inventory
    {
        public int code { get; set; }
        public string  productName { get; set; }
        public int  productQuantity { get; set; }
        public double  productPrice { get; set; }
        public Inventory()
        {

        }        

    } 
    class Function:Inventory
    {
        public void ADD()
        {
            Console.Write("Enter the Product Code \n");
            code = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Product Name \n");
            productName = Console.ReadLine();
            Console.Write("Enter the Product Quantity \n");
            productQuantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Product Price \n");
            productPrice = Convert.ToDouble(Console.ReadLine());
        }     
        public void Buy(Function[] adds)
        {
            Console.WriteLine("Enter the Product Code");
            int co = Convert.ToInt32(Console.ReadLine());
            foreach (var item in adds)
            {
                if (co==item.code)
                {
                    Console.WriteLine("Enter the quantity of the product u want to buy\n");
                    int qun = Convert.ToInt32(Console.ReadLine());
                    if(qun<=item.productQuantity)
                    {
                        Console.WriteLine("You are buying\n" + item.productName);
                        item.productQuantity -= qun;
                        Console.Write("\nThe left out quantinty is\n" + item.productQuantity);
                        Console.WriteLine("\nTotal Price is \n" + (qun * item.productPrice));
                    }
                    else
                    {
                        Console.WriteLine("Required Quantity not there");
                    }
                }
                else
                {
                    Console.WriteLine("product not present");
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Function[] adds = null;
            for (; ; )
            {
                Console.WriteLine("What is the function u want to do");
                String s = Console.ReadLine();
                s = s.ToLower();              
                if (s.Equals("add"))
                {
                    Console.WriteLine("Enter the Number of products to be entered");
                    int n = Convert.ToInt32(Console.ReadLine());
                    adds = new Function[n];
                    Console.WriteLine("Do u want to stop adding Y/N");
                        String c = Console.ReadLine();
                        if (c.ToLower() == "n")
                        {
                            for (int i = 0; i < adds.Length; i++)
                            {
                                Function add = new Function();
                                add.ADD();
                                adds[i] = add;
                            }
                            c = Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    
                }
                else if (s.Equals("buy"))
                {
                    Function buy = new Function();
                    buy.Buy(adds);
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
