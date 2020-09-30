using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace MyCustomListUnitTests
{
    [TestClass]
    public class ToStringMethodTests
    {
        [TestMethod] // Test 1
        public void ToString_AddTwo1IntValues_ToStringEquals11()
        {
            // Arrange

            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            string expected = "11";
            string actual;

            // Act

            list.Add(value1);
            list.Add(value1);
            actual = list.ToString();

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 2
        public void ToString_AddThreeBoolValues_ToStringEqualsTrueFalseTrue()
        {
            // Arrange

            CustomList<bool> list = new CustomList<bool>();
            string expected = "TrueFalseTrue";
            string actual;

            // Act

            list.Add(true);
            list.Add(false);
            list.Add(true);
            actual = list.ToString();

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 3
        public void ToString_AddFourCharValues_ToStringEqualsABCD()
        {
            // Arrange

            CustomList<char> list = new CustomList<char>();
            string expected = "ABCD";
            string actual;

            // Act

            list.Add('A');
            list.Add('B');
            list.Add('C');
            list.Add('D');
            actual = list.ToString();

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 4
        public void ToString_NoValuesInCustomList_ToStringReturnsEmptyString()
        {
            // Arrange

            CustomList<char> list = new CustomList<char>();
            string expected = "";
            string actual;

            // Act

            actual = list.ToString();

            // Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
