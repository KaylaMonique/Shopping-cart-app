using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShoppingLibrary
{
    public class ShoppingCart //zoo
    {
        List<ShoppingCartItem> _ShoppingCartItem = new List<ShoppingCartItem>();
        //private List<ShoppingCartItems> _ShoppingCartItems;

        public ShoppingCart()
        {
           
        }
        public void AddItem(ShoppingCartItem item)
        {
            _ShoppingCartItem.Add(item);
        }

        public double GetSubTotal()
        {
            double total = 0;

            foreach(ShoppingCartItem shoppingCart in _ShoppingCartItem)
            {
                total = total + shoppingCart.Price;
            }
            return total;
        }
        public double GetVat()
        {
            double vat = 0;

            vat += 1.15 * GetSubTotal();
            
            return vat;
        }
        public List<ShoppingCartItem>GetShoppingCartItems()
        {
            return _ShoppingCartItem;   
        }
    }
}
