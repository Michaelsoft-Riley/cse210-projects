using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(3, 5);

        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
    }
}