using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Constructors
    public Fraction() // No-argument constructor, initializes to 1/1
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator) // Initializes to numerator/1
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator) // Initializes with both numerator and denominator
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters and Setters
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _denominator = denominator;
    }

    // Method to return fraction as a string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}

