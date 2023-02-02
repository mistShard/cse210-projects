using System;

public class Fraction {
    private double _numerator;
    private double _denominator;
    public Fraction() {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(double numerator) {
        _numerator = numerator;
        _denominator = 1;
    }
    public Fraction(double numerator, double denominator) {
        _numerator = numerator;
        _denominator = denominator;
    }
    
    public double GetNumerator() {
        return _numerator;
    }
    public double GetDenominator() {
        return _denominator;
    }
    public void SetNumerator(double numerator) {
        _numerator = numerator;
    }
    public void SetDenominator(double denominator) {
        _denominator = denominator;
    }
    public void GetFractionString() {
        string fraction = $"{_numerator}/{_denominator}";
        Console.WriteLine(fraction);
    }
    public void GetFractionDecimal() {
        double fraction = _numerator / _denominator;
        Console.WriteLine(fraction);
    }
}