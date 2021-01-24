using NUnit.Framework;
using ZabawneDodawaniePiotrusia;

namespace UnitTests.ZabawneDodawaniePiotrusia
{
    [TestFixture]
    public class PalindromicCheckerTest
    {
        [Test]
        public void ShouldTreatOneDigitNumbersAsPalindromic()
        {
            // Arrange
            var numberToTest = "1";

            // Act
            var result = PalindromicChecker.Check(numberToTest);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ShouldReturnTrueForPalindromicNumbers()
        {
            // Arrange
            var numberToTest = "12321";

            // Act
            var result = PalindromicChecker.Check(numberToTest);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ShouldReturnFalseForNonPalindromicNumbers()
        {
            // Arrange
            var numberToTest = "7784563";

            // Act
            var result = PalindromicChecker.Check(numberToTest);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        [TestCase("12", ExpectedResult = false)]
        [TestCase("123", ExpectedResult = false)]
        [TestCase("963213", ExpectedResult = false)]
        [TestCase("55555", ExpectedResult = true)]
        [TestCase("555", ExpectedResult = true)]
        [TestCase("1221", ExpectedResult = true)]
        [TestCase("12321", ExpectedResult = true)]
        public bool ShouldCorrectlyDistinguishTestCases(string input)
        {
            return PalindromicChecker.Check(input);
        }
    }
}
