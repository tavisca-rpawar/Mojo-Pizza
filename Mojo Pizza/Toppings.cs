﻿namespace Mojo_Pizza
{
    public class Toppings
    {
        public enum type { Vegan, NonVegan}
        public string Type { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
