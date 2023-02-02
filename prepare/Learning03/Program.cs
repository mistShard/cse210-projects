using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        fraction.SetNumerator(1);
        fraction.SetDenominator(3);
        fraction.GetFractionString();
        fraction.GetFractionDecimal();
    }
}