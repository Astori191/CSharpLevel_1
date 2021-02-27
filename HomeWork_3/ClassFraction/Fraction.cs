using System;

namespace ClassFraction
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction()
        {
            this.numerator = 1;
            this.denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator == 0)
            {
                throw new ArgumentException("0 is not allowed", "denominator");
            }
            this.denominator = denominator;
        }

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set 
            { 
                if (value == 0)
                {
                    throw new ArgumentException("0 is not allowed", "denominator");
                }
                denominator = value;
            }
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


        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            Fraction normalizedF1 = new Fraction();
            Fraction normalizedF2 = new Fraction();

            Normalize(f1, f2, ref normalizedF1, ref normalizedF2);

            result.numerator = normalizedF1.numerator + normalizedF2.numerator;
            result.denominator = normalizedF1.denominator;

            return result;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();

            Fraction normalizedF1 = new Fraction();
            Fraction normalizedF2 = new Fraction();

            Normalize(f1, f2, ref normalizedF1, ref normalizedF2);

            result.numerator = normalizedF1.numerator - normalizedF2.numerator;
            result.denominator = normalizedF1.denominator;

            return result;
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();

            result.numerator = f1.numerator * f2.numerator;
            result.denominator = f1.denominator * f2.denominator;

            return result;
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();

            result.numerator = f1.numerator * f2.denominator;
            result.denominator = f1.denominator * f2.numerator;

            return result;
        }

        public static void Normalize(Fraction f1, Fraction f2, ref Fraction normalizedF1, ref Fraction normalizedF2)
        {
            normalizedF1.numerator = f1.numerator * f2.denominator;
            normalizedF1.denominator = f1.denominator * f2.denominator;

            normalizedF2.numerator = f2.numerator * f1.denominator;
            normalizedF2.denominator = f2.denominator * f1.denominator;
        }



    }


}
