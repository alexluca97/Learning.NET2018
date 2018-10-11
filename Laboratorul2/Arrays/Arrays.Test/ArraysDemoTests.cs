using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arrays.Test
{
    [TestClass]
    public class ArraysDemoTests
    {
        private const string COLOR_RED = "Red";
        private const int ARRAY_LENGHT = 4;

        private ArraysDemo sut;

        [TestInitialize]
        public void TestInitialize()
        {
            sut = new ArraysDemo();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            sut = null;
        }

        [TestMethod]
        public void When_ArraysDemoIsCalled_ThenShould_HaveArrayLenght4()
        {
            // Arrange && Act
            var result = sut.ArrayLenght();
            // Assert
            Assert.IsTrue(result == ARRAY_LENGHT);
        }

        [TestMethod]
        public void When_IndexIsLeftOutOfRange_ThenShould_ThrowException()
        {
            // Arrange && Act
            var elementByPosition = sut.GetElementByPosition(0);
            // Assert
            Assert.IsTrue(elementByPosition == COLOR_RED);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void When_Condition_ThenShould_Result1()
        {
            // Arrange && Act
            sut.GetElementByPosition(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void When_IndexIsRightOutOfRange_ThenShould_ThrowException()
        {
            // Arrange && Act
            sut.GetElementByPosition(sut.ArrayLenght() + 1);
        }
    }
}
