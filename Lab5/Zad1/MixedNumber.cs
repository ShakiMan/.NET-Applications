using System;
using System.Collections.Generic;
using System.Text;

//Ścigała Radosław, 246997

namespace Zad1
{
    class MixedNumber
    {
        public int IntegerPart { get; set; }

        private int numeratorNumber;
        public int Numerator
        {
            get
            {
                return numeratorNumber;
            }
            set
            {
                numeratorNumber = Math.Abs(value);
            }
        }

        private int denominatorNumber;
        public int Denominator
        {
            get
            {
                return denominatorNumber;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Mianownik nie może być zerem.", nameof(value));
                }
                else
                {
                    denominatorNumber = Math.Abs(value);
                    SimplifyFormOfFraction();
                }
            }
        }

        public static int ShiftCounter { get; private set; } = 0;

        public MixedNumber(int integerPart, int numerator, int denominator)
        {
            numerator = System.Math.Abs(numerator);
            denominator = System.Math.Abs(denominator);
            IntegerPart = integerPart;
            Numerator = numerator;
            Denominator = denominator;
            SimplifyFormOfFraction();
        }

        public MixedNumber(int numerator, int denominator) : this(0, numerator, denominator)
        {
        }

        public MixedNumber(int integerPart) : this(integerPart, 0, 1)
        {
        }

        public MixedNumber() : this(0, 0, 1)
        {
        }

        public MixedNumber(double realNumber)
        {
            int integerPart = Convert.ToInt32(realNumber);
            int numerator = Math.Abs(Convert.ToInt32((realNumber % 1) * 100));
            int denominator = 100;
            IntegerPart = integerPart;
            Numerator = numerator;
            Denominator = denominator;
            SimplifyFormOfFraction();
        }

        public void SimplifyFormOfFraction()
        {
            if (numeratorNumber != 0)
            {
                MixedNumber.ShiftCounter++;

                int nwd = NWD(numeratorNumber, denominatorNumber);
                numeratorNumber /= nwd;
                denominatorNumber /= nwd;

                int additionalIntegerPart = numeratorNumber / denominatorNumber;
                if (denominatorNumber != 0 && additionalIntegerPart != 0)
                {
                    IntegerPart += additionalIntegerPart;
                    numeratorNumber -= denominatorNumber * (additionalIntegerPart);
                }
            }
        }

        private int NWD(int fst, int scd)
        {
            while (fst != scd)
            {
                if (fst > scd)
                    fst -= scd;
                else
                    scd -= fst;
            }
            return fst;
        }

        public static MixedNumber operator +(MixedNumber fst, MixedNumber scd)
        {
            int firstDenominator = fst.denominatorNumber;
            int secondDenominator = scd.denominatorNumber;
            int firstNumarator, secondNumerator, sumNumerator, commonDenominator;
            //numerator of the (first) improper fraction
            if (fst.IntegerPart < 0)
            {
                firstNumarator = -1 * fst.Numerator + fst.IntegerPart * fst.Denominator;
            }
            else
            {
                firstNumarator = fst.Numerator + fst.IntegerPart * fst.Denominator;
            }
            //numerator of the (second) improper fraction
            if (scd.IntegerPart < 0)
            {
                secondNumerator = -1 * scd.Numerator + scd.IntegerPart * scd.Denominator;
            }
            else
            {
                secondNumerator = scd.Numerator + scd.IntegerPart * scd.Denominator;
            }
            //common denominator
            if (fst.Denominator == scd.Denominator)
            {
                commonDenominator = scd.Denominator;
                sumNumerator = firstNumarator + secondNumerator;
            }
            else
            {
                commonDenominator = fst.Denominator * scd.Denominator;
                sumNumerator = firstNumarator * secondDenominator + secondNumerator * firstDenominator;
            }

            MixedNumber sum = new MixedNumber();            
            sum.Numerator = sumNumerator;
            sum.Denominator = commonDenominator;
            if (sumNumerator < 0)
            {
                sum.IntegerPart = -1 * sum.IntegerPart;
            }
            return sum;
        }

        public override string ToString() 
        {
            if (IntegerPart == 0)
            {
                if (numeratorNumber == 0)
                {
                    return "0";
                }
                return numeratorNumber.ToString() + "/" + denominatorNumber.ToString();
            }
            if (numeratorNumber == 0)
            {
                return IntegerPart.ToString();
            }
            return IntegerPart.ToString() + " " + numeratorNumber.ToString() + "/" + denominatorNumber.ToString();
        }
    }
}
