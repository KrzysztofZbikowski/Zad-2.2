class Zad
{
    static void Main(string[] args)
    {
        double a, b, c, delta;
        Console.WriteLine("Podaj a: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj b: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj c: ");
        c = double.Parse(Console.ReadLine());
        delta = Math.Pow(b,2) - 4 * a * c;
        Console.WriteLine("Delta wynosi: " + delta);
        Console.ReadKey();
    }
}