namespace FractionLibrary
{
    public class Fraction
    {
        // Attributes
        private int numerator;
        private int denominator;

        // properties

        public int Numerator
        {
            get { return numerator; }
            set { if (value == 0) { }
                else { numerator = value; }
            }
        }

        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0) 
                { }
                else { 
                denominator = value;
                } 
            }
        }


        // Methods
        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            if(denominator == 0 )
            {
                
            }
            else
            {
                this.denominator = denominator;
            }
            
        }

        public Fraction Add(Fraction right)
        {
            int newNumerator = numerator*right.Denominator + denominator*right.Numerator;
            int newDenominator = denominator * right.Denominator;
            Fraction result = new Fraction(newNumerator, newDenominator);
            result.Simplify();
            return result;

        }

        public Fraction Subtract(Fraction right)
        {
            int newNumerator = numerator * right.denominator - denominator * right.numerator;
            int newDenominator = denominator * right.denominator;
            Fraction result = new Fraction(newNumerator, newDenominator);
            result.Simplify();
            return result;
        }

        public Fraction Multiply(Fraction right)
        {
            return new Fraction(Numerator*right.Numerator, Denominator*right.Denominator);
        }

        public Fraction Divide(Fraction right)
        {
            return new Fraction(Numerator * right.Denominator, Denominator * right.Numerator);
        }


        public Fraction Reciprocal()
        {
            int number = Numerator;
            numerator = Denominator;
            Denominator = number;
            return this;
        }

        public Fraction Invert()
        { 
            Numerator = -Numerator;
            return this;
        }

        public Fraction Simplify()
        {
            
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
            if (numerator < 0 && denominator < 0)
            {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }
            else if (numerator > 0 && denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }


            return new Fraction(numerator, denominator);
        }
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public double Result()
        {
            double result = Convert.ToDouble(numerator) / Convert.ToDouble(denominator);
            return result;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

    }
}