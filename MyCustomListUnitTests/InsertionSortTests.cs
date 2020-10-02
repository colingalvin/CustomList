using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace MyCustomListUnitTests
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod] // Test 1
        public void Sort_List135246_ReturnList123456()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            string expected = "123456";
            string actual;

            // Act
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list1.Add(2);
            list1.Add(4);
            list1.Add(6);
            CustomList<int>.InsertionSort(list1);
            actual = list1.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 2
        public void Sort_ListDoubles_ReturnList1234()
        {
            // Arrange
            CustomList<double> list1 = new CustomList<double>();
            string expected = "1.12.23.34.4";
            string actual;

            // Act
            list1.Add(4.4);
            list1.Add(2.2);
            list1.Add(1.1);
            list1.Add(3.3);
            CustomList<double>.InsertionSort(list1);
            actual = list1.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 3
        public void Sort_ListAaBbCc_ReturnListABCabc()
        {
            // Arrange
            CustomList<char> list1 = new CustomList<char>();
            string expected = "ABCabc";
            string actual;

            // Act
            list1.Add('A');
            list1.Add('a');
            list1.Add('B');
            list1.Add('b');
            list1.Add('C');
            list1.Add('c');
            CustomList<char>.InsertionSort(list1);
            actual = list1.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 4
        public void Sort_ListTrueFalseTrueFalse_ReturnListFalseFalseTrueTrue()
        {
            // Arrange
            CustomList<bool> list1 = new CustomList<bool>();
            string expected = "FalseFalseTrueTrue";
            string actual;

            // Act
            list1.Add(true);
            list1.Add(false);
            list1.Add(true);
            list1.Add(false);
            CustomList<bool>.InsertionSort(list1);
            actual = list1.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 5
        public void Sort_ListWorldHello_ReturnListHelloWorld()
        {
            // Arrange
            CustomList<string> list1 = new CustomList<string>();
            string expected = "HelloWorld";
            string actual;

            // Act
            list1.Add("World");
            list1.Add("Hello");
            CustomList<string>.InsertionSort(list1);
            actual = list1.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
