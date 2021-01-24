using KabalistycznyZapisDaty;
using NUnit.Framework;

namespace UnitTests.KabalistycznyZapisDaty
{
    [TestFixture]
    public class KabbalahConverterTest
    {
        [Test]
        [TestCase('A', ExpectedResult = 1)]
        [TestCase('H', ExpectedResult = 8)]
        [TestCase('O', ExpectedResult = 50)]
        [TestCase('T', ExpectedResult = 100)]
        [TestCase('V', ExpectedResult = 200)]
        [TestCase('X', ExpectedResult = 300)]
        [TestCase('Y', ExpectedResult = 400)]

        public int ShouldCorrectlyReturnTheNumber(char input)
        {
            return KabbalahConverter.ConvertCharToKabbalahNumber(input);
        }
    }
}
