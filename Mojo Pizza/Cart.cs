using System;
using System.Collections.Generic;
namespace Mojo_Pizza
{
    public class Cart
    {
        List<Pizza> cartItems = new List<Pizza>();
        public void AddToCart(Toppings toppings, Size size)
        {
            cartItems.Add( new Pizza { Toppings = toppings, Size = size});
        }
        public void DisplayCartItems()
        {
            int totalPrice =0;
            int cartTotal = 0;
            Console.WriteLine("\n======== Your Cart Has " + cartItems.Count + " Pizzas ========");
            foreach(var item in cartItems)
            {
                Console.WriteLine("Size - " + item.Size.Name + " Rs " + item.Size.Price);
                Console.WriteLine("Toppings - " + item.Toppings.Name +" Rs " + item.Toppings.Price);
                totalPrice = item.Size.Price + item.Toppings.Price;
                cartTotal += totalPrice;
                Console.WriteLine("Total Price \t Rs "+totalPrice+ "\n");
            }
            Console.WriteLine("Cart Total " + cartTotal);
            Console.WriteLine("========================================");
        }
    }
}
