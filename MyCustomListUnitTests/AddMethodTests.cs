using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace MyCustomListUnitTests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod] // Test 1
        public void Add_AddTwoIntValues_CountEquals2()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 2;

            // Act

            list.Add(value1);
            list.Add(value2);

            // Assert

            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod] // Test 2
        public void Add_AddIntValue_ValueIsAt0Index()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int expected = 1;
            int actual;

            // Act

            list.Add(value1);
            actual = list[0];

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 3
        public void Add_Add3BoolValues_ValueIsAt2Index()
        {
            // Arrange

            CustomList<bool> list = new CustomList<bool>();
            bool value1 = true;
            bool expected = true;
            bool actual;

            // Act

            list.Add(value1);
            list.Add(value1);
            list.Add(value1);
            actual = list[2];

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 4
        public void Add_Add2CharValues_ValueIsAt1Index()
        {
            // Arrange

            CustomList<char> list = new CustomList<char>();
            char char1 = 'A';
            char char2 = 'a';
            char expected = 'a';
            char actual;

            // Act

            list.Add(char1);
            list.Add(char2);
            actual = list[1];

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 5
        public void Add_Add5Values_CapacityEquals8()
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
            actual = list.Capacity;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 6
        public void Add_Add5IntValues_CorrectValueAtIndex2()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 3; // Expected value at index 2
            int actual;

            // Act

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            actual = list[2];

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 7
        public void Add_Add5IntValues_CorrectValueAtIndex4()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 5; // Expected value at index 3
            int actual;

            // Act

            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            actual = list[4];

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 1
        public void Add_Add7IntValues_CountEquals7()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int expected = 7;

            // Act

            list.Add(value1);
            list.Add(value1);
            list.Add(value1);
            list.Add(value1);
            list.Add(value1);
            list.Add(value1);
            list.Add(value1);

            // Assert

            Assert.AreEqual(expected, list.Count);
        }
    }
}
