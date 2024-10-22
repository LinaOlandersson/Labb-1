namespace Labb_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new(5);
            Console.WriteLine($"En cirkelradie på {c1.Radius} ger följande:\n" +
                $"Area: {c1.GetArea()}\nOmkrets: {c1.GetCircumfence()}" +
                $"\nVolym: {c1.GetVolume()}\n\n");

            Circle c2 = new(6);
            Console.WriteLine($"En cirkelradie på {c2.Radius} ger följande:\n" +
                $"Area: {c2.GetArea()}\nOmkrets: {c2.GetCircumfence()}" +
                $"\nVolym: {c2.GetVolume()}\n\n");

            Triangle t1 = new(5);
            Console.WriteLine($"En triangelsida på {t1.SideLength} ger följande:\n" +
                $"Area: {t1.GetArea()}\nOmkrets: {t1.GetCircumfence()}\n\n");

            Triangle t2 = new(6);
            Console.WriteLine($"En triangelsida på {t2.SideLength} ger följande:\n" +
                $"Area: {t2.GetArea()}\nOmkrets: {t2.GetCircumfence()}\n\n");
        }
    }
}
