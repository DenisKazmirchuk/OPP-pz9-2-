using System;

class Program
{
    static void Main()
    {
        Func<double, double, double, bool> isTriangle = (a, b, c) =>
            a + b > c && a + c > b && b + c > a;

        Console.Write("Введіть першу сторону: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введіть другу сторону: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введіть третю сторону: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine(isTriangle(a, b, c) ? "Сторони утворюють трикутник." : "Сторони не утворюють трикутник.");
    }
}
