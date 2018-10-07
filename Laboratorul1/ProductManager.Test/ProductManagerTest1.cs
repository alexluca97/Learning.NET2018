using System;
using Xunit;
using ProductManager;

namespace ProductManager.Test
{
    public class ProductManagerTest1
    {
        [Fact]
        public void TestIfProductIsValid()
        {
            var product1 = new Product("Product1", "SmallProduct", DateTime.Today.AddDays(1), 100.00);
            var product2 = new Product("Product2", "SmallProduct", DateTime.Now, 100.00);
            Assert.True(product1.IsValid());
            Assert.False(product2.IsValid());

        }

        [Fact]
        public void TestIfProductVATIsCorrect()
        {
            var product = new Product("Product2", "BigProduct", DateTime.Today.AddDays(1), 200.00);
            Assert.Equal(50, product.ComputeVAT());
        }

        [Fact]
        public void TestIfArhitectFullNameOk()
        {
            var arhitect1 = new Arhitect("Luca", "Alexandru", DateTime.Today.AddDays(1), 250);
            Assert.Equal("Luca Alexandru", arhitect1.GetFullName());
        }

        [Fact]
        public void TestIfArhitectIsAvtive()
        {
            var arhitect1 = new Arhitect("Luca", "Alexandru", DateTime.Today.AddDays(1), 250);
            var arhitect2 = new Arhitect("Anton", "Vlad", DateTime.Now, 220);
            Assert.True(arhitect1.IsActive());
            Assert.False(arhitect2.IsActive());
        }

        [Fact]
        public void TestIfManagerFullNameOk()
        {
            var manager1 = new Manager("Luca", "Alexandru", DateTime.Today.AddDays(1), 250);
            Assert.Equal("Luca Alexandru", manager1.GetFullName());
        }

        [Fact]
        public void TestIfManagerIsActive()
        {
            var manager1 = new Manager("Luca", "Alexandru", DateTime.Today.AddDays(1), 250);
            var manager2 = new Manager("Anton", "Vlad", DateTime.Now, 220);
            Assert.True(manager1.IsActive());
            Assert.False(manager2.IsActive());
        }
    }
}
