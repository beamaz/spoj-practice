
using NUnit.Framework;
using NWD;

namespace UnitTests.NWD
{
    [TestFixture]
    public class TheGreatestCommonDivisorComputerTest
    {
        [Test]
        public void ShouldReturnOneForTwoPrimeNumbers()
        {
            //Arrange
            var firstNumber = 7;
            var secondNumber = 11;

            //Act
            int result = TheGreatestCommonDivisorComputer.Gcd(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void ShouldReturnTheSameNumberForTwoEqualNumbers()
        {
            //Arrange
            var number = 98;

            //Act
            int result = TheGreatestCommonDivisorComputer.Gcd(number, number);

            //Assert
            Assert.AreEqual(98, result);
        }

        [Test]
        [TestCase(2, 4, ExpectedResult = 2)]
        [TestCase(99, 24, ExpectedResult = 3)]
        [TestCase(11, 121, ExpectedResult = 11)]
        public int ShouldReturnTheCorrectlyValue(int firstNumber, int secondNumber)
        {
            return TheGreatestCommonDivisorComputer.Gcd(firstNumber, secondNumber);
        }
    }
}
