using System;
using System.Collections.Generic;
using Xunit;

namespace ProductManager.Test
{
    public class ProductManagerTest1
    {


        private List<Product> productList = new List<Product>
        {
            new Product(1,"product1", "test1",DateTime.MinValue,  DateTime.MaxValue, 12.5f),
            new Product(2,"product2", "test2",DateTime.MinValue,  new DateTime(), 12.5f),
            new Product(3,"product3", "test3", DateTime.MinValue, new DateTime(), 12.5f)
        };

        public ProductRepository ProductRepository;
        [Fact]
        public void GivenProductName_ShouldFindProductByName()
        {
            ProductRepository = new ProductRepository(productList);
            Assert.Equal(productList[0], ProductRepository.GetProductByName("product1"));
        }

        [Fact]
        public void GivenProductName_ShouldReturnNull()
        {
            ProductRepository = new ProductRepository(productList);
            Assert.Equal(null, ProductRepository.GetProductByName("product10"));
        }

        [Fact]
        public void GivenListOfProduct_ShouldReturnAllProducts()
        {
            ProductRepository = new ProductRepository(productList);
            Assert.Equal(productList,ProductRepository.FindAllProducts());
        }

        [Fact]
        public void GivenProduct_ShouldAddProductToTheList()
        {
            ProductRepository = new ProductRepository(productList);
            var product4 = new Product(4,"product4","test4",DateTime.MinValue, DateTime.MaxValue, 12.5f);
            ProductRepository.AddProduct(product4);
            Assert.Equal(product4, ProductRepository.GetProductByName("product4"));
        }

        [Fact]
        public void GivenIndexOfProduct_ShouldReturnProductWithThatIndex()
        {
            ProductRepository = new ProductRepository(productList);
            Assert.Equal(productList[1], ProductRepository.GetProductByPosition(1));
        }

        [Fact]
        public void GivenProductName_ShouldReturnTrueForRemovingThatProduct()
        {
            ProductRepository = new ProductRepository(productList);
            Assert.True(ProductRepository.RemoveProductByName("product2"));
        }

        [Fact]
        public void GivenProductName_ShouldReturnFalseForRemovingThatProduct()
        {
            ProductRepository = new ProductRepository();
            Assert.False(ProductRepository.RemoveProductByName("product1"));
        }

        [Fact]
        public void GivenProduct_ShouldReturnTrueForBeingValid()
        {
            var product = new Product(1,"product1","test1",DateTime.MinValue, DateTime.MaxValue, 12.5f);
            Assert.True(product.IsValid());
        }

        [Fact]
        public void GivenProduct_ShouldReturnFalseForBeingValid()
        {
            var product = new Product(1, "product1", "test1", DateTime.MaxValue, DateTime.MaxValue, 12.5f);
            Assert.False(product.IsValid());
        }
    }
}
