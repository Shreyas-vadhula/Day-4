using System;

namespace Sample5
{
    class Program
    {
        class Inventory
        {
            public int code1 = 1;
            public int code2 = 2;
            public string product1 = "mangoes";
            public string product2 = "apples";
            public int product1Quan = 200;
            public int product2Quan = 200;
        }

        class Customer : Inventory
        {
            public void Buyer()
            {
                Console.WriteLine("Enter the product code");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("The selected Product is \t" + product1);
                    Console.WriteLine("Enter the Quantity");
                    int quan = Convert.ToInt32(Console.ReadLine());
                    if (quan <= product1Quan)
                    {
                        product1Quan -= quan;
                        Console.WriteLine("The no of pieces left is\t " + product1Quan);
                    }
                    else
                    {
                        Console.WriteLine("Quantity Not Available.");
                    }

                }
                else if (n == 2)
                {
                    Console.WriteLine("The selected Product is \t" + product2);
                    Console.WriteLine("Enter the Quantity");
                    int quan = Convert.ToInt32(Console.ReadLine());
                    if (quan <= product2Quan)
                    {
                        product2Quan -= quan;
                        Console.WriteLine("The no of pieces left is\t " + product2Quan);
                    }
                    else
                    {
                        Console.WriteLine("Quantity Not Available.");
                    }
                }
                else
                {
                    Console.WriteLine("Product Not Available");
                }

            }
            public void Wholeseller()
            {
                Console.WriteLine("Enter the product code");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("The selected Product is \t" + product1);
                    Console.WriteLine("Enter the Quantity");
                    int quan = Convert.ToInt32(Console.ReadLine());
                    product1Quan += quan;
                    Console.WriteLine("The no of pieces left is\t "+product1Quan);


                }
                else if (n == 2)
                {
                    Console.WriteLine("The selected Product is \t" + product2);
                    Console.WriteLine("Enter the Quantity");
                    int quan = Convert.ToInt32(Console.ReadLine());
                    product2Quan += quan;
                    Console.WriteLine("The no of pieces left is\t " + product2Quan);

                }
                else
                {
                    Console.WriteLine("Product Not Available");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter whether u are a Buyer Or Wholeseller");
            String c = Console.ReadLine();
            if(c.Equals("Buyer"))
            {
                Customer buyer = new Customer();
                buyer.Buyer();
            }
            else if (c.Equals("Wholeseller"))
            {
                Customer wholeseller = new Customer();
                wholeseller.Wholeseller();
            }
            else
            {
                Console.Write("Invalid Entry");
            }
            Console.ReadLine();
        }
    }
}
