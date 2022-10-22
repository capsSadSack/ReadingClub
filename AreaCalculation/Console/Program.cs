Console.Write("Enter side1 = ");
double a = double.Parse(Console.ReadLine());
Console.Write("Enter side2 = ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine($"Area = {GetRectArea(a, b)}");
Console.ReadLine();



double GetRectArea(double side1, double side2)
{
    if (side1 < 0 || side2 < 0)
        throw new ArgumentException();
    return side1 * side2;
}
