using System.Collections.Generic;
using System.Linq; // used for .Sum() method
using Products;    

namespace Cart
{
    class ShoppingCart
    {
        private List<Product > Cart_Items = new List<Product>();
        public decimal SubTotal => Cart_Items.Sum(item=> item.Price);

        public void AddToCart(Product product)
        {
            if(product != null)
            {
                Cart_Items.Add(product);
            }
        }
        public List<Product> GetItem() => Cart_Items;

    }


}
