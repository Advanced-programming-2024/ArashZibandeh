public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        this.numerator = numerator;
        this.denominator = denominator;
    }

    public Fraction Add(Fraction other)
    {
        int newNumerator = this.numerator * other.denominator + other.numerator * this.denominator;
        int newDenominator = this.denominator * other.denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Subtract(Fraction other)
    {
        int newNumerator = this.numerator * other.denominator - other.numerator * this.denominator;
        int newDenominator = this.denominator * other.denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Multiply(Fraction other)
    {
        int newNumerator = this.numerator * other.numerator;
        int newDenominator = this.denominator * other.denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction GCD(Fraction other)
    {
        int a = this.numerator;
        int b = other.denominator;
        while (a != 0)
        {
            int temp = b % a;
            b = a;
            a = temp;
        }
        return new Fraction(1, b);
    }

    public Fraction Simplify()
    {
        Fraction gcd = GCD(this);
        return new Fraction(this.numerator / gcd.numerator, this.denominator / gcd.denominator);
    }

    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }
}
