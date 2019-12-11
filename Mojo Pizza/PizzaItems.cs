using System.Collections.Generic;
namespace Mojo_Pizza
{
    public class PizzaItems
    {
        static string vegan = Toppings.type.Vegan.ToString();
        static string nonVegan = Toppings.type.NonVegan.ToString();
        List<Toppings> toppingsList;
        public List<Toppings> GetToppingsList()
        {
            toppingsList = new List<Toppings>()
            {
                new Toppings() { Type = vegan , Name = "Olive", Price = 40},
                new Toppings() { Type = vegan, Name = "Onion", Price = 50},
                new Toppings() { Type = nonVegan, Name = "Chicken", Price = 70},
                new Toppings() { Type = nonVegan, Name = "Mutton", Price = 60},
            };
            return toppingsList;
        }
        public Toppings GetSelectedTopping(int toppingIndex )
        {
            toppingIndex--;
            var topping = toppingsList[toppingIndex];
            return topping;
        }
        List<Size> sizeList;
        public List<Size> GetPizzaSize()
        {
            sizeList = new List<Size>()
            {
                new Size() { Name = "Small", Price = 50 },
                new Size() { Name = "Medium", Price = 75 },
                new Size() { Name = "Large", Price = 100 },
            };
            return sizeList;
        }
        public Size GetSelectedSize(int sizeIndex)
        {
            sizeIndex--;
            var size = sizeList[sizeIndex];
            return size;
        }
    }
}
