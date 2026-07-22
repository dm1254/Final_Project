using System.Collections.Generic;

namespace Products
{
    class ProductCatalog
    {
        private Dictionary<int, Product > Items = new Dictionary<int, Product>();

        public void AddItem(int ProductCode, Product product)
        {
            if (!Items.ContainKey(ProductCode))
            {
                Items.Add(ProductCode, product);
            }
        }

        public string GetProduct(int ProductCode)
        {
            Items.TryGetValue(ProductCode, out Product product);
            return product;
        }
    }


}
