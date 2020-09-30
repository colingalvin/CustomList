using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace MyCustomListUnitTests
{
    [TestClass]
    public class AddOperatorTests
    {
        [TestMethod] // Test 1
        public void AddOperator_List135_List246_ResultList135246()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3;
            string expected = "135246";
            string actual;

            // Act
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);
            list3 = list1 + list2;
            actual = list3.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 2
        public void AddOperator_ListACE_ListBDF_ResultListHasCount6()
        {
            // Arrange
            CustomList<char> list1 = new CustomList<char>();
            CustomList<char> list2 = new CustomList<char>();
            CustomList<char> list3;
            int expected = 6;
            int actual;

            // Act
            list1.Add('a');
            list1.Add('c');
            list1.Add('e');
            list2.Add('b');
            list2.Add('d');
            list2.Add('f');
            list3 = list1 + list2;
            actual = list3.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 3
        public void AddOperator_EmptyList_ListTrueFalseTrue_ResultListTrueFalseTrue()
        {
            // Arrange
            CustomList<bool> list1 = new CustomList<bool>();
            CustomList<bool> list2 = new CustomList<bool>();
            CustomList<bool> list3;
            string expected = "TrueFalseTrue";
            string actual;

            // Act
            list2.Add(true);
            list2.Add(false);
            list2.Add(true);
            list3 = list1 + list2;
            actual = list3.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 4
        public void AddOperator_EmptyList_ListGoPackGo_ResultListCount3()
        {
            // Arrange
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            CustomList<string> list3;
            string expected = "GoPackGo";
            string actual;

            // Act
            list2.Add("Go");
            list2.Add("Pack");
            list2.Add("Go");
            list3 = list1 + list2;
            actual = list3.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 5
        public void AddOperator_EmptyList_EmptyList_ResultListEmpty()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3;
            string expected = "";
            string actual;

            // Act
            list3 = list1 + list2;
            actual = list3.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 6
        public void AddOperator_EmptyList_EmptyList_ResultListHasCount0()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3;
            int expected = 0;
            int actual;

            // Act
            list3 = list1 + list2;
            actual = list3.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

       
