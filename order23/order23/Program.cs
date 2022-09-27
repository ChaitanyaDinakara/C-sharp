using System.Runtime.InteropServices;

namespace order23
{
    public class Order
    {

        public void details()
        {
            Console.WriteLine("1234");
            Console.WriteLine("Tejas");
        }

        public class FoodOrder : Order
        {
            double price,cost;
            void print()
            {

                Console.WriteLine("enter the price for food");
                price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(cost = price + (price * 5/100));
            }

            public class GroceryOrder : FoodOrder
            {
                void print1()
                {

                    Console.WriteLine("enter the price for groceries");
                    price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(cost = price +(price * 8/100));
                }

            public class ClothingOrder :GroceryOrder
                {
                     public void print2()
                    {
                        Console.WriteLine("enter the price for clothes shopping");
                        price= Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(cost = price +(price * 10/100));
                    }
                }


                static void Main(string[] args)
                {
                    Order O = new Order();
                    O.details();
                    FoodOrder F = new FoodOrder();
                    F.print();
                    GroceryOrder G = new GroceryOrder();
                    G.print1();
                    ClothingOrder C = new ClothingOrder();
                    C.print2();
                }
            }
        }
    }
}
