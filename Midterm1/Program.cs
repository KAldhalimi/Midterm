using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t                  GG           GG");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t                GG           GG");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t               GG           GG");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t                     GG          GG ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t             CCCCCCCCCCCCCCCCCCCCCCCCC");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t            CCCCCCC           CCCCCCCCCCCCC");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t           CCCCCCCC              CC      CC ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t            CCCCCCC           CCCCCCCCCCCCC ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t             CCCCCCCCCcccCCCCCCCCCCCcC");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n                         K&K");
            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            List<Product> ShoppingCart = new List<Product>();
            bool goOn = true;
            while (goOn == true)

            {
                List<Product> Shoelist = new List<Product>();

                Shoelist.Add(new Product("Cole Haan", "Flats", "Leopard", 140));
                Shoelist.Add(new Product("Christian Louboutin", "Heels", "Glitter", 240));
                Shoelist.Add(new Product("Tamara Mellon", "Boots", "Stretchy", 340));
                Shoelist.Add(new Product("Gucci", "Wedges", "Open-Toe", 150));
                Shoelist.Add(new Product("Cole Haan", "Comfort", "Track Shoes", 160));
                Shoelist.Add(new Product("Steve Madden", "Flats", "Leopard", 75));
                Shoelist.Add(new Product("Yasmin Bootie", "Heels", "Glitter", 100));
                Shoelist.Add(new Product("Franko Sarto", "Boots", "Stretchy", 140));
                Shoelist.Add(new Product("Dansko Christina", "Wedges", "Open-Toe", 85));
                Shoelist.Add(new Product("Steve Madden", "Comfort", "Track Shoes", 65));
                Shoelist.Add(new Product("Yadira Wedge", "Boots", "Stretchy", 140));
                Shoelist.Add(new Product("Steve Madden", "Wedges", "Open-Toe", 85));


                for (int i = 0; i < Shoelist.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Shoelist[i].Name}, { Shoelist[i].Category}, {Shoelist[i].Description}");
                }
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("what item would you like to buy?");
                int userSelection = int.Parse(Console.ReadLine());


                ShoppingCart.Add(Shoelist[userSelection - 1]);
                Console.WriteLine("You selected--" + Shoelist[userSelection - 1].Name);
                Console.WriteLine("The price of--" + Shoelist[userSelection - 1].price);

                Console.WriteLine("Would you like to keep shopping? (y/n)?");
                string UserInput = Console.ReadLine().ToLower();
                if (UserInput == "n")
                {
                    goOn = false;


                    double Subtotal = 0;
                    double TotalTax = 0;
                    double userChange;

                    for (int i = 0; i < ShoppingCart.Count; i++)
                    {
                        Subtotal = ShoppingCart[i].price + Subtotal;
                    }
                    TotalTax = (Subtotal * 0.06) + Subtotal;
                    Console.WriteLine("the subtotal for your item is {0:C2}", Subtotal);
                    Console.WriteLine("your total with tax is {0:C2}", TotalTax);

                    double total = 0.0;
                    if (ShoppingCart.Count == 0)
                    {
                        Console.WriteLine($"Your cart contains No item ");
                        foreach (var item in ShoppingCart)
                        {
                            Console.WriteLine($"{item.Name} {item.price}");
                            total = total + (item.price * 1.06 / 100) + item.price;
                        }
                    }
                    else if (ShoppingCart.Count <= 12)
                    {
                        Console.WriteLine($"Your cart contains ({ShoppingCart.Count}) item ");
                        foreach (var item in ShoppingCart)
                        {
                            Console.WriteLine($"{item.Name} {item.price,0:C}");
                            total = total + (item.price * 1.06 / 100) + item.price;
                        }
                    }


                   
                    {
                        double userPayment = double.Parse(Console.ReadLine());
                        userChange = userPayment - TotalTax;
                        Console.WriteLine("Thank you for your payment. Your change is: {0:C2}", userChange);
                        Console.WriteLine("Here is your receipt. Please come shop with us again!");

                        //Receipt shown below

                        for (int i = 0; i < ShoppingCart.Count; i++)
                        {

                            Console.WriteLine("Items ordered: {0}, {1}", ShoppingCart[i].Name, ShoppingCart[i].price);

                        }

                        Console.WriteLine("Subtotal: {0:C2}", Subtotal);
                        Console.WriteLine("Grandtotal: {0:C2}", TotalTax);
                        Console.WriteLine("Amount Paid: {0:C2}", userPayment);
                    }



                    }
                }
            }
        }
    }




















