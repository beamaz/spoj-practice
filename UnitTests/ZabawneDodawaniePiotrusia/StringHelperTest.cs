using NUnit.Framework;
using ZabawneDodawaniePiotrusia;

namespace UnitTests.ZabawneDodawaniePiotrusia
{
    [TestFixture]
    public class StringHelperTest
    {
        [Test]
        public void ShouldCorrectlyReverseTwoDigitNumbers()
        {
            //Arrange
            var number = "82";

            //Act
            var result = StringHelper.ReverseStringAndConvertToInt(number);

            //Assert
            Assert.AreEqual(28, result);
        }

        [Test]
        public void ShouldCorrectlyReverseOneDigitNumbers()
        {
            //Arrange
            var number = "1";
            
            //Act
            var result = StringHelper.ReverseStringAndConvertToInt(number);

            //Assert
            Assert.AreEqual(1, result);
        }
        [Test]
        public void ShouldCorrectlyReverseLongNumbers()
        {
            //Arrange
            var number = "123456789";

            //Act
            var result = StringHelper.ReverseStringAndConvertToInt(number);

            //Assert
            Assert.AreEqual(987654321, result);
        }
    }
}
