using System;
using System.Collections.Generic;

namespace ShoppingLibrary
{
    public class ShoppingCart //zoo
    {
        List<ShoppingCartItem> _ShoppingCartItem = new List<ShoppingCartItem>();

        public ShoppingCart()
        {
            ShoppingCartItem shoppingCartItem = new ShoppingCartItem("xBox", 3950.99);
            _ShoppingCartItem.Add(shoppingCartItem);

            shoppingCartItem = new ShoppingCartItem("PS4", 5999.49);
            _ShoppingCartItem.Add(shoppingCartItem);

            shoppingCartItem = new ShoppingCartItem("Nintendo", 2599.99);
            _ShoppingCartItem.Add(shoppingCartItem);

        }
    }
}
