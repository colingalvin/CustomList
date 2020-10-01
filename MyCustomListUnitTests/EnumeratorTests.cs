using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace MyCustomListUnitTests
{
    [TestClass]
    public class EnumeratorTests
    {
        [TestMethod] // Test 1
        public void GetEnumerator_List1234_EmptyList_List2SameAsList1()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            string expected = "1234";
            string actual;

            // Act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            foreach (int item in list1)
            {
                list2.Add(item);
            }
            actual = list2.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 2
        public void GetEnumerator_EmptyList_ListABCD_List2RemainsUnchanged()
        {
            // Arrange
            CustomList<char> list1 = new CustomList<char>();
            CustomList<char> list2 = new CustomList<char>();
            string expected = "abcd";
            string actual;

            // Act
            list2.Add('a');
            list2.Add('b');
            list2.Add('c');
            list2.Add('d');
            foreach (char item in list1)
            {
                list2.Add(item);
            }
            actual = list2.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 3
        public void GetEnumerator_ListTrueTrue_ListFalseFalse_ResultListTrueTrueFalseFalse()
        {
            // Arrange
            CustomList<bool> list1 = new CustomList<bool>();
            CustomList<bool> list2 = new CustomList<bool>();
            string expected = "TrueTrueFalseFalse";
            string actual;

            // Act
            list1.Add(true);
            list1.Add(true);
            list2.Add(false);
            list2.Add(false);
            foreach (bool item in list2)
            {
                list1.Add(item);
            }
            actual = list1.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
