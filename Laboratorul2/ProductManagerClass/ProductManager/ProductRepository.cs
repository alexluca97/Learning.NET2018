using System.Collections.Generic;

namespace ProductManager
{
    public class ProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>();
        }

        public ProductRepository(List<Product> products)
        {
            _products = products;
        }

        public Product GetProductByName(string productName)
        {
            foreach (var product in _products)
            {
                if (product.Name == productName)
                {
                    return product;
                }
            }

            return null;
        }

        public List<Product> FindAllProducts()
        {
            return _products;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public Product GetProductByPosition(int position)
        {
            return _products[position];
        }

        public bool RemoveProductByName(string productName)
        {
            foreach (var product in _products)
            {
                if (product.Name == productName)
                {
                    _products.Remove(product);
                    return true;
                }
            }

            return false;
        }
    }
}
