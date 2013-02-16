using RomanNumerals.Interfaces;
using System;
using System.Text;

namespace RomanNumerals
{
    public class ShahabsRomanNumeralGenerator : RomanNumeralGenerator
    {
        const int MINIMUM_NUMBER_CONVERSION = 1;
        const int MAXIMUM_NUMBER_CONVERSION = 3999;

        public string Generate(int number)
        {
            if (number < MINIMUM_NUMBER_CONVERSION || number > MAXIMUM_NUMBER_CONVERSION)
            {
                throw new ArgumentOutOfRangeException("number", string.Format("This roman numeral generator only support generation of symbols between {0} and {1}.", MINIMUM_NUMBER_CONVERSION, MAXIMUM_NUMBER_CONVERSION));
            }

            var digitsGenerator = new DigitsGenerator();
            var digits = digitsGenerator.Generate(number);

            var stringBuilder = new StringBuilder();

            foreach (var digit in digits)
            {
                stringBuilder.Append(digit.ToRomanNumeralString());
            }

            return stringBuilder.ToString();
        }
    }
}
