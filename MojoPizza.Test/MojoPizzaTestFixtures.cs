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
        
        
    }
}
