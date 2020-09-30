using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace MyCustomListUnitTests
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod] // Test 1
        public void Remove_Add3IntValues_RemoveInt1_Countis2()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            int expected = 2;
            int actual;

            // Act

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(1);
            actual = list.Count;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 2
        public void Remove_Add3IntValues_RemoveInt1_RemoveReturnsTrue()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            bool expected = true;
            bool actual;

            // Act

            list.Add(1);
            list.Add(2);
            list.Add(3);
            actual = list.Remove(1);

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 3
        public void Remove_Add3CharValues_RemoveNonexistentChar_CountRemainsSame()
        {
            // Arrange

            CustomList<char> list = new CustomList<char>();
            int expected = 3;
            int actual;

            // Act

            list.Add('a');
            list.Add('b');
            list.Add('c');
            list.Remove('d');
            actual = list.Count;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 4
        public void Remove_Add3CharValues_RemoveNonexistentChar_RemoveReturnsFalse()
        {
            // Arrange

            CustomList<char> list = new CustomList<char>();
            bool expected = false;
            bool actual;

            // Act

            list.Add('a');
            list.Add('b');
            list.Add('c');
            actual = list.Remove('d');

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 5
        public void Remove_Add4BoolValues_RemoveTrue_Index1IsTrue()
        {
            // Arrange

            CustomList<bool> list = new CustomList<bool>();
            bool expected = true;
            bool actual;

            // Act

            list.Add(true);
            list.Add(false);
            list.Add(true);
            list.Add(false);
            list.Remove(true);
            actual = list[1];

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 6
        public void Remove_Add6IntValues_Remove1Item_CapacityEquals8()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int expected = 8;
            int actual;

            // Act

            list.Add(value1);
            list.Add(value1);
            list.Add(value1);
            list.Add(value1);
            list.Add(value1);
            list.Add(value1);
            list.Remove(value1);
            actual = list.Capacity;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 7
        public void Remove_Add6IntValues_Remove1Item_CountEquals5()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int expected = 5;
            int actual;

            // Act

            list.Add(value1);
            list.Add(value1);
            list.Add(value1);
            list.Add(value1);
            list.Add(value1);
            list.Add(value1);
            list.Remove(value1);
            actual = list.Count;

            // Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
