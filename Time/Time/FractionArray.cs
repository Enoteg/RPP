using System;

public class Fraction
{
    private static int count = 0; 
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int numerator = 0, int denominator = 1)
    {
        Numerator = numerator;
        Denominator = denominator != 0 ? denominator : 1; 
        count++;
    }

    public static int GetObjectCount()
    {
        return count;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}
