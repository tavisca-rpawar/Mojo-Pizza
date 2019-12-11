using System;
using System.Collections.Generic;
using System.Linq;
namespace Mojo_Pizza
{
    class Program
    {
        public static Size AddPizzaSize()
        {
            PizzaItems pizzaItems = new PizzaItems();
            int counter = 0;
            List<Size> sizeList = pizzaItems.GetPizzaSize();
            foreach (var size in sizeList)
            {
                Console.WriteLine(++counter + " - " + size.Name + "\t Rs " + size.Price);
            }
            string sizeIndex = Console.ReadLine();
            var selectedSize = pizzaItems.GetSelectedSize(Int32.Parse(sizeIndex));
            return selectedSize;
        }
        public static Toppings AddPizzaToppings()
        {
            PizzaItems pizzaItems = new PizzaItems();
            int counter = 0;
            List<Toppings> toppingsList = pizzaItems.GetToppingsList();
            foreach (var topping in toppingsList)
            {
                Console.WriteLine(++counter + " - " + topping.Name + "\t Rs " + topping.Price);
            }
            string toppingIndex = Console.ReadLine();
            var seletedTopping = pizzaItems.GetSelectedTopping(Int32.Parse(toppingIndex));
            return seletedTopping;
        }
        static void PlaceOrder()
        {
            Console.WriteLine("Do You want to Place Order Y/N");
            string orderInput = Console.ReadLine();
            if (orderInput.ToLower() == "y")
            {
                Order order = new Order();
                order.PlaceOrder();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("EXIT");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Cart cart = new Cart();

            Console.WriteLine("Welcome to Pizza World -Mojo Pizza \n \n");
            Size selectedSize;
            Toppings seletedTopping;
            string checkout;
            do
            {
                Console.WriteLine("Select Pizza Size \n");
                selectedSize = AddPizzaSize();
                Console.WriteLine("Select Pizza Toppings \n ");
                seletedTopping = AddPizzaToppings();
                cart.AddToCart(seletedTopping, selectedSize);
                Console.WriteLine("DO you want to Add More pizze? Y/N ");
                checkout = Console.ReadLine();

            } while (checkout.ToLower() == "y");
            
            cart.DisplayCartItems();
            PlaceOrder();
        }
    }
}
