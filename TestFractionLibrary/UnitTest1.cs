using FractionLibrary;

namespace TestFractionLibrary
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            Fraction fraction1 = new Fraction(1, 5);
            Fraction fraction2 = new Fraction(2, 5);
            Fraction sum1 = fraction1.Add(fraction2);
            double result = sum1.Result();
            Fraction expected1 = new Fraction(3,5);
            double expected1d = expected1.Result();
            Assert.Equal(expected1d, result);


            
        }
        [Fact]
        public void testSubtract()
        {
            Fraction fraction1 = new Fraction(3, 5);
            Fraction fraction2 = new Fraction(2, 5);
            Fraction sum1 = fraction1.Subtract(fraction2);
            double result = sum1.Result();
            Fraction expected1 = new Fraction(1, 5);
            double expected1d = expected1.Result();
            Assert.Equal(expected1d, result);
        }
        [Fact]
        public void testMultiply()
        {
            Fraction fraction1 = new Fraction(3, 5);
            Fraction fraction2 = new Fraction(2, 5);
            Fraction sum1 = fraction1.Multiply(fraction2);
            double result = sum1.Result();
            Fraction expected1 = new Fraction(6, 25);
            double expected1d = expected1.Result();
            Assert.Equal(expected1d, result);
        }
        [Fact]
        public void testDivide()
        {
            Fraction fraction1 = new Fraction(4, 5);
            Fraction fraction2 = new Fraction(2, 5);
            Fraction sum1 = fraction1.Divide(fraction2);
            double result = sum1.Result();
            Fraction expected1 = new Fraction(2,1 );
            double expected1d = expected1.Result();
            Assert.Equal(expected1d, result);
        }
        [Fact]
        public void testToString()
        {
            Fraction fraction = new Fraction(3, 5);
            string actual = fraction.ToString();
            string expected = "3/5";
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void testResult() 
        {
            Fraction fraction = new Fraction(3, 5);
            double actual = fraction.Result();
            double expected = 0.6;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testSimplify()
        {
            Fraction fraction = new Fraction(3, 15);
            string expected = "1/5";
            fraction = fraction.Simplify();
            string actual = fraction.ToString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testInvert() 
        { 
            Fraction fraction = new Fraction(1 ,5 );
            string expected = "-1/5";
            fraction = fraction.Invert();
            string actual = fraction.ToString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testReciprocal() 
        {
            Fraction fraction = new Fraction(2 ,5);
            string expected = "5/2";
            fraction = fraction.Reciprocal();
            string actual = fraction.ToString();
            Assert.Equal(expected, actual);
        }
    }
}