using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace MyCustomListUnitTests
{
    [TestClass]
    public class SubtractOperatorTests
    {
        [TestMethod] // Test 1
        public void SubtractOperator_List123_List216_ReturnList35()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3;
            string expected = "35";
            string actual;

            // Act
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(1);
            list2.Add(6);
            list3 = list1 - list2;
            actual = list3.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 2
        public void SubtractOperator_ListABC_ListBCD_ReturnListCount1()
        {
            // Arrange
            CustomList<char> list1 = new CustomList<char>();
            CustomList<char> list2 = new CustomList<char>();
            CustomList<char> list3;
            int expected = 1;
            int actual;

            // Act
            list1.Add('a');
            list1.Add('b');
            list1.Add('c');
            list2.Add('b');
            list2.Add('c');
            list2.Add('d');
            list3 = list1 - list2;
            actual = list3.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 3
        public void SubtractOperator_ListTrueFalseTrue_EmptyList_ReturnListTrueFalseTrue()
        {
            // Arrange
            CustomList<bool> list1 = new CustomList<bool>();
            CustomList<bool> list2 = new CustomList<bool>();
            CustomList<bool> list3;
            string expected = "TrueFalseTrue";
            string actual;

            // Act
            list1.Add(true);
            list1.Add(false);
            list1.Add(true);
            list3 = list1 - list2;
            actual = list3.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 4
        public void SubtractOperator_EmptyList_ListTrueFalseTrue_ReturnEmptyList()
        {
            // Arrange
            CustomList<bool> list1 = new CustomList<bool>();
            CustomList<bool> list2 = new CustomList<bool>();
            CustomList<bool> list3;
            string expected = "";
            string actual;

            // Act
            list2.Add(true);
            list2.Add(false);
            list2.Add(true);
            list3 = list1 - list2;
            actual = list3.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 5
        public void SubtractOperator_List123_List111_ReturnList23()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3;
            string expected = "23";
            string actual;

            // Act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(1);
            list2.Add(1);
            list2.Add(1);
            list3 = list1 - list2;
            actual = list3.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 6
        public void SubtractOperator_ListTrueFalseFalse_ListFalse_ReturnListTrueFalse()
        {
            // Arrange
            CustomList<bool> list1 = new CustomList<bool>();
            CustomList<bool> list2 = new CustomList<bool>();
            CustomList<bool> list3;
            string expected = "TrueFalse";
            string actual;

            // Act
            list1.Add(true);
            list1.Add(false);
            list1.Add(false);
            list2.Add(false);
            list3 = list1 - list2;
            actual = list3.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
