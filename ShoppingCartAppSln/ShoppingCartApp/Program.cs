using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace ShoppingCartApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();

            ShoppingCartItem shoppingCartItem = new ShoppingCartItem("xBox", 3950.99);
            cart.AddItem(shoppingCartItem);

            shoppingCartItem = new ShoppingCartItem("PS4", 5999.49);
            cart.AddItem(shoppingCartItem);

            shoppingCartItem = new ShoppingCartItem("Bike", 2599.99);
            cart.AddItem(shoppingCartItem);

            List<ShoppingCartItem> items = cart.GetShoppingCartItems();
            foreach(ShoppingCartItem item in items)
            {
                Console.Write(item.Name + "\t\t");
                Console.WriteLine(item.Price);
            }

            Console.WriteLine("Sub Total: \t" + cart.GetSubTotal());
            Console.WriteLine("With Vat: \t" + cart.GetVat());
        }
    }
}
