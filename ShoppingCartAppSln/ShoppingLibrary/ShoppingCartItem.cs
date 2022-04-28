using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCartItem //animals
    {
        private string _itemName;
        private double _itemPrice;
       // public double subTotal;
        
        public string Name
        {
            get { return _itemName; }
        }

        public double Price
        {
            get { return _itemPrice; }
        }

        public ShoppingCartItem(string itemName, double itemPrice)
        {
            _itemName = itemName;
            _itemPrice = itemPrice;
        }        
    }
}
