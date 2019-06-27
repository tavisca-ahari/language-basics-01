using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tavisca.Bootcamp.LanguageBasics.Exercise1;

namespace LanguageBasics1Tests
{
    [TestClass]
    public class FixMultiplicationTests
    {
        [TestMethod]
        public void Digit_MissingIn_FirstOperand()
        {
            // Arrange
            string equation = "4?*47=1974";
            int expected = 2;

            // Act
            int actual = FixMultiplication.FindDigit(equation);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Digit_MissingIn_SecondOperand()
        {
            // Arrange
            string equation = "42*?7=1974";
            int expected = 4;

            // Act
            int actual = FixMultiplication.FindDigit(equation);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Digit_MissingIn_Product()
        {
            // Arrange
            string equation = "42*47=1?74";
            int expected = 9;

            // Act
            int actual = FixMultiplication.FindDigit(equation);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void When_NumberHas_LeadingZero()
        {
            // Arrange
            string equation = "42*?47=1974";
            int expected = -1;

            // Act
            int actual = FixMultiplication.FindDigit(equation);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_NoSolution()
        {
            // Arrange
            string equation = "2*12?=247";
            int expected = -1;

            // Act
            int actual = FixMultiplication.FindDigit(equation);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
