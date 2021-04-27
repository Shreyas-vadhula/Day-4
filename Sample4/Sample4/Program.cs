using System;

namespace Sample9
{
    class Program
    {
        class Product
        {
            public String ProName { get; set; }
            public int ProQuan { get; set; }
            public double ProPrice { get; set; }
            public Product()
            {

            }

            public Product(int _Quan, string _Name, double _Price)
            {


                ProName = _Name;
                ProQuan = _Quan;
                ProPrice = _Price;

            }
            public void EnterDetails()
            {

                Console.WriteLine("Enter Product name");
                ProName = Console.ReadLine();
                Console.WriteLine("Enter the quantity required");
                ProQuan = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Price of 1 " + ProName);
                ProPrice = Convert.ToDouble(Console.ReadLine());

            }
        }

        class Invoice : Product
        {

            public void Head()
            {
                Console.WriteLine("\n\nSl.No \t\t Product name \t\t Quantity \t\t Price of 1 \t\t Total Price");
            }

            public void PrintInvoice(Product[] products)
            {
                int i = 0;
                foreach (var item in products)
                {
                    Console.WriteLine((i + 1) + "\t\t" + item.ProName + "\t\t\t" + item.ProQuan + "\t\t\t" +item.ProPrice + "\t\t\t" + (item.ProQuan * item.ProPrice));
                    i = i + 1;
                }

            }
        }

        class Class14
        {
            public static void Main()
            {
                Console.WriteLine("Enter the Number of products to be entered");
                int n = Convert.ToInt32(Console.ReadLine());
                Product[] products = new Product[n];
                for (int i = 0; i < products.Length; i++)
                {
                    Product product = new Product();
                    product.EnterDetails();
                    products[i] = product;

                }
                Invoice invoice = new Invoice();
                invoice.Head();
                invoice.PrintInvoice(products);
                Console.ReadLine();
            }




        }
    }
}