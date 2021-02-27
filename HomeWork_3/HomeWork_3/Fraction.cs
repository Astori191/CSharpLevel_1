using System;

namespace HomeWork_3
{
    class Fraction
    {
        public double numerator;
        public double denominator;

        public Fraction()
        {
            this.numerator = 1;
            this.denominator = 1;
        }

        public Fraction(double numerator, double denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public string PrintFraction()
        {
            string toPrint = "";

            if (this.numerator < 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                toPrint = $"{this.numerator}/{this.denominator}"; 
            }

            return toPrint;
        }

        public static void NOZ()
        {

        }
   
    }


}
