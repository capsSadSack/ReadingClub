namespace Convertion.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        public void SingleRomanNumber_Convert_CorrectArabicNumber(
            string romanNumber, int expectedArabicNumber)
        {
            int actualArabicNumber = RomanNumeralConverter.ToArabic(romanNumber);

            Assert.AreEqual(expectedArabicNumber, actualArabicNumber);
        }

        [TestCase("IV", 4)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("XVIII", 18)]
        [TestCase("XIX", 19)]
        [TestCase("MCMXCIV", 1994)]
        public void ComplexRomanNumber_Convert_CorrectArabicNumber(
            string romanNumber, int expectedArabicNumber)
        {
            int actualArabicNumber = RomanNumeralConverter.ToArabic(romanNumber);

            Assert.AreEqual(expectedArabicNumber, actualArabicNumber);
        }

        [TestCase("XVIe")]
        [TestCase("-XIX")]
        [TestCase(" X")]
        public void BadSymbols_Convert_ArgumentException(string romanNumber)
        {
            Assert.Throws<ArgumentException>(() =>
                RomanNumeralConverter.ToArabic(romanNumber));
        }
    }
}