using Mojo_Pizza;
using System.Collections.Generic;
using Xunit;

namespace MojoPizza.Test
{
    public class MojoPizzaTestFixtures
    {
        PizzaItems pizzaItems = new PizzaItems();
        [Fact]
        public void GetToppingsList_Should_Return_List_Of_Toppings()
        {
            List<Toppings> toppingsList = pizzaItems.GetToppingsList();
            int expected = toppingsList.Count;
            int actual = 4;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void GetSizeList_Should_Return_List_Of_Sizes()
        {
            List<Size> sizeList = pizzaItems.GetPizzaSize();
            int expected = sizeList.Count;
            int actual = 3;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void GetSelectedTopping_Should_Return_Selected_Topping()
        {
            List<Toppings> toppingsList = pizzaItems.GetToppingsList();
            var expected = pizzaItems.GetSelectedTopping(2);
            var actual = new Toppings { Name = "Onion", Price = 50, Type = "Vegan" };
            actual.Equals(expected);
        }
        [Fact]
        public void GetPizzaSize_Should_Return_Selected_Size()
        {
            List<Size> sizeList = pizzaItems.GetPizzaSize();
            var expected = pizzaItems.GetSelectedSize(3);
            var actual = new Size { Name = "Large", Price = 100 };
            actual.Equals(expected);
        }
    }
}
