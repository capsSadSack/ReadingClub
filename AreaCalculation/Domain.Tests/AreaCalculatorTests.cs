namespace Domain.Tests
{
    public class AreaCalculatorTests
    {
        [Test]
        public void PositiveSides_GetRectArea_CorrectArea()
        {
            double side1 = 3;
            double side2 = 7;
            double expectedArea = 21;

            double actualArea = AreaCalculator.GetRectArea(side1, side2);

            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void NegativeSide_GetRectArea_ArgumentException()
        {
            double side1 = -3;
            double side2 = 7;

            Assert.Throws<ArgumentException>(() =>
            {
                AreaCalculator.GetRectArea(side1, side2);
            });
        }
    }
}