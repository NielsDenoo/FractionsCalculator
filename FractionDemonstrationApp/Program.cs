using FractionLibrary;

namespace FractionDemonstrationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fourTenth = new Fraction(4,10);
            Fraction twoSixth = new Fraction(2,6);
            
            fourTenth.Simplify();
            Console.WriteLine($"Vervoudiging van 4/10: " + fourTenth);

            Fraction sixTwo = twoSixth.Reciprocal();
            Console.WriteLine($"Omgekeerde breuk van {twoSixth}: {sixTwo}");

            Fraction sum = fourTenth.Add(twoSixth);

            Console.WriteLine($"De som van {fourTenth} en { twoSixth} is {sum}");

            Fraction threeFifth = new Fraction(3, 5);
            Fraction subtract = fourTenth.Subtract(threeFifth);
            Console.WriteLine($"Het verschil van {fourTenth} en {threeFifth} is {subtract}");

            Fraction eightTenth = new Fraction(8,10);
            Fraction multiply = fourTenth.Multiply(eightTenth);

            Console.WriteLine($"Het product van {fourTenth} en {eightTenth} is {multiply}");

            Fraction twoFifth = new Fraction(2,5);
            Fraction divide = fourTenth.Divide(twoFifth);
            
            Console.WriteLine($"De deling van {fourTenth} en {twoFifth} is {divide}");

            Console.WriteLine($"Het resultaat in natuurlijke getallen is: {divide.Result()}");

            Fraction nFourTenth = fourTenth.Invert();

            Console.WriteLine(nFourTenth);
        }
    }
}