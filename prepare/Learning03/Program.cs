using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing all constructors
        Fraction frac1 = new Fraction(); // 1/1
        Fraction frac2 = new Fraction(5); // 5/1
        Fraction frac3 = new Fraction(3, 4); // 3/4
        Fraction frac4 = new Fraction(1, 3); // 1/3

        // Displaying fractions and their decimal values
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());

        // Testing getters and setters
        frac3.SetNumerator(7);
        frac3.SetDenominator(9);
        Console.WriteLine($"Updated Fraction: {frac3.GetFractionString()}");
        Console.WriteLine($"Updated Decimal Value: {frac3.GetDecimalValue()}");
    }
}
