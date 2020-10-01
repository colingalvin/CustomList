using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace MyCustomListUnitTests
{
    [TestClass]
    public class IndexerTests
    {
        [TestMethod] // Test 1
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_EmptyList_GetIndex0_ExceptionThrown()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();

            // Act
            Console.WriteLine(list1[0]);
        }

        [TestMethod] // Test 2
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexerSet_EmptyList_SetIndex0_ExceptionThrown()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();

            // Act
            list1[0] = 3;
        }

        [TestMethod] // Test 3
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_GetIndexOutsideOfCount_ExceptionThrown()
        {
            // Arrange
            CustomList<char> list1 = new CustomList<char>();

            // Act
            list1.Add('a');
            list1.Add('b');
            Console.WriteLine(list1[2]);
        }

        [TestMethod] // Test 4
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_SetIndexOutsideOfCount_ExceptionThrown()
        {
            // Arrange
            CustomList<char> list1 = new CustomList<char>();

            // Act
            list1.Add('a');
            list1.Add('b');
            list1[2] = list1[1];
        }

        [TestMethod] // Test 5
        public void Indexer_GetExistingIndex_IndexSuccessfullyRetrieved()
        {
            // Arrange
            CustomList<bool> list1 = new CustomList<bool>();
            string expected = "True";
            string actual;

            // Act
            list1.Add(true);
            list1.Add(false);
            list1.Add(true);
            actual = list1[2].ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 6
        public void Indexer_SetExistingIndex_IndexSuccessfullyReassigned()
        {
            // Arrange
            CustomList<bool> list1 = new CustomList<bool>();
            string expected = "TrueFalseTrue";
            string actual;

            // Act
            list1.Add(true);
            list1.Add(false);
            list1.Add(true);
            list1[2] = list1[0];
            actual = list1.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
