using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace MyCustomListUnitTests
{
    [TestClass]
    public class RemoveAtMethodTests
    {
        [TestMethod] // Test 1
        public void RemoveAt_Add3IntValues_RemoveIndex1_Countis2()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            int expected = 2;
            int actual;

            // Act

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.RemoveAt(1);
            actual = list.Count;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 2
        public void RemoveAt_Add3IntValues_RemoveIndex1_Index1Equals3()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            int expected = 3;
            int actual;

            // Act

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.RemoveAt(1);
            actual = list[1];

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 3
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_Add3CharValues_RemoveIndex3_ExceptionThrown()
        {
            // Arrange

            CustomList<char> list = new CustomList<char>();

            // Act

            list.Add('a');
            list.Add('b');
            list.Add('c');
            list.RemoveAt(3);
        }

        [TestMethod] // Test 4
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_Add3CharValues_RemoveIndexLessThan0_ExceptionThrown()
        {
            // Arrange

            CustomList<char> list = new CustomList<char>();

            // Act

            list.Add('a');
            list.Add('b');
            list.Add('c');
            list.RemoveAt(-1);
        }

        [TestMethod] // Test 5
        public void RemoveAt_Add6IntValues_RemoveIndex4_CountEquals5()
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
            list.RemoveAt(4);
            actual = list.Count;

            // Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
