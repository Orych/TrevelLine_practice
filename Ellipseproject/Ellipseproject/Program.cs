using Ellipseproject;
class Program
{
    public static void Main(string[] args)
    {
        point Centre = new point
        {
            X = 0,
            Y = 0
        };
        int HorizontalRadius = 5;
        int VerticalRadius = 3;
        try
        {
            Figure ellipse = new Figure(Centre, HorizontalRadius, VerticalRadius);

            Console.WriteLine($"Площадь эллипса -> {ellipse.Square()}");
            Console.WriteLine($"Длина дуги эллипса -> {ellipse.Lenght()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}