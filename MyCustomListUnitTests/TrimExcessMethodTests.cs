using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace MyCustomListUnitTests
{
    [TestClass]
    public class TrimExcessMethodTests
    {
        [TestMethod] // Test 1
        public void TrimExcess_ListTrueFalseTrue_CapacityRemains4()
        {
            // Arrange
            CustomList<bool> list1 = new CustomList<bool>();
            int expected = 4;
            int actual;

            // Act
            list1.Add(true);
            list1.Add(false);
            list1.Add(true);
            list1.TrimExcess();
            actual = list1.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 2
        public void TrimExcess_Listabcde_CapacityIs5()
        {
            // Arrange
            CustomList<char> list1 = new CustomList<char>();
            int expected = 5;
            int actual;

            // Act
            for (int i = 0; i < 5; i++)
            {
                list1.Add('a');
            }
            list1.TrimExcess();
            actual = list1.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 3
        public void TrimExcess_List11111_RemoveAllItems_CapacityIs0()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 0;
            int actual;

            // Act
            for (int i = 0; i < 5; i++)
            {
                list1.Add(1);
            }
            for (int i = 0; i < 5; i++)
            {
                list1.Remove(1);
            }
            list1.TrimExcess();
            actual = list1.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 4
        public void TrimExcess_List11111_Remove2Items_CapacityIs3()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 3;
            int actual;

            // Act
            for (int i = 0; i < 5; i++)
            {
                list1.Add(1);
            }
            for (int i = 0; i < 2; i++)
            {
                list1.Remove(1);
            }
            list1.TrimExcess();
            actual = list1.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 5
        public void TrimExcess_List11111_Remove2Items_Trim_Add4Items_CapacityIs6()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 6;
            int actual;

            // Act
            for (int i = 0; i < 5; i++)
            {
                list1.Add(1);
            }
            for (int i = 0; i < 2; i++)
            {
                list1.Remove(1);
            }
            list1.TrimExcess();
            list1.Add(1);
            actual = list1.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 6
        public void TrimExcess_List30Items_CapacityRemains32()
        {
            // Arrange
            CustomList<string> list1 = new CustomList<string>();
            int expected = 30;
            int actual;

            // Act
            for (int i = 0; i < 30; i++)
            {
                list1.Add("Hello");
            }
            
            list1.TrimExcess();
            actual = list1.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
