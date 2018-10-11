using System;
using GenericLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericListTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string CITY = "Bacau";

        [TestMethod]
        public void When_ClassIsInstanciated_ThenShould_Have3Elements()
        {
            // Arrange && Act
            var list = new GenericStringList();
            // Assert
            Assert.IsTrue(list.Capacity() == 3);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_AddedNullCity_ThenShould_ThrowException()
        {
            // Arrange && Act
            var list = new GenericStringList();
            list.AddCity(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void When_RemoveNullCity_ThenShould_ThrowException()
        {
            // Arrange && Act
            var list = new GenericStringList();
            list.RemoveCity(null);
        }

        [TestMethod]
        public void When_AddedNotCity_ThenShould_IncreaseListCapacity()
        {
            // Arrange && Act
            var list = new GenericStringList();
            var oldCapacity = list.Capacity();
            // Act
            list.AddCity("Constanta");
            // Assert
            Assert.AreEqual(oldCapacity + 1, list.Capacity());
        }

        [TestMethod]
        public void When_RemoveNotNullCity_ThenShould_DecreaseListCapacity()
        {
            // Arrange 
            var list = new GenericStringList();
            list.AddCity(CITY);
            var oldCapacity = list.Capacity();
            // Act
            list.RemoveCity(CITY);
            // Assert
            Assert.AreEqual(oldCapacity - 1, list.Capacity());
        }

    }
}
