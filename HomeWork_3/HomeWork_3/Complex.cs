using System;
namespace HomeWork_3
{
    class Complex
    {
        public double re;
        public double im;

        public Complex()
        {
            this.re = 0;
            this.im = 0;
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public string Print()
        {
            string toPrint = String.Empty;

            if (this.im < 0)
            {
                toPrint = $"{this.re} - {-this.im}i";
            }
            else if (this.im == 0)
            {
                toPrint = $"{this.re}";
            } 
            else
            {
                toPrint = $"{this.re} + {this.im}i";
            }

            return toPrint;
        }

        public static Complex Addition(Complex z1, Complex z2)
        {
            Complex additionResult = new Complex();
            additionResult.re = z1.re + z2.re;
            additionResult.im = z1.im + z2.im;

            return additionResult;
        }
        public static Complex Subtraction(Complex z1, Complex z2)
        {
            Complex subtractionResult = new Complex();
            subtractionResult.re = z1.re - z2.re;
            subtractionResult.im = z1.im - z2.im;

            return subtractionResult;
        }

        public static Complex Multiplication(Complex z1, Complex z2)
        {
            Complex multiplicationResult = new Complex();
            multiplicationResult.re = (z1.re * z2.re) - (z1.im * z2.im);
            multiplicationResult.im = (z1.re * z2.im) + (z1.im * z2.re);
            return multiplicationResult;
        }

    }
   
}
