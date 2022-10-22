namespace Domain
{
    public static class AreaCalculator
    {
        public static double GetRectArea(double side1, double side2)
        {
            if (side1 < 0 || side2 < 0)
                throw new ArgumentException("Negative side");
            return side1 * side2;
        }
    }
}