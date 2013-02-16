using System;

namespace RomanNumerals
{
    public class Digit
    {
        private readonly int _value;
        private readonly int _placeValue;

        public Digit(char character, int position, int numberOfDigitsMakingUpTheNumberThatContainsThisDigit)
        {
            _value = int.Parse(character.ToString());
            _placeValue = (int)Math.Pow(10, (numberOfDigitsMakingUpTheNumberThatContainsThisDigit - position - 1));
        }

        public string ToRomanNumeralString()
        {
            if (_placeValue == 1000)
            {
                return BuildNumeral("M");
            }
            else if (_placeValue == 100)
            {
                return BuildNumeral("C", "D", "M");
            }
            else if (_placeValue == 10)
            {
                return BuildNumeral("X", "L", "C");
            }
            else
            {
                return BuildNumeral("I", "V", "X");
            }
        }

        private string BuildNumeral(string subtractSymbol)
        {
            string romanNumeral = string.Empty;

            for (int index = 0; index < _value; index++)
            {
                romanNumeral += subtractSymbol;
            }

            return romanNumeral;
        }

        private string BuildNumeral(string leftPlaceValueRomanSymbol, string middlePlaceValueRomanSymbol, string rightPlaceValueRomanSymbol)
        {
            string romanNumeral = string.Empty;

            if (_value >= 1 && _value <= 3)
            {
                for (int index = 0; index < _value; index++)
                {
                    romanNumeral += leftPlaceValueRomanSymbol;
                }
            }
            else if (_value == 4)
            {
                romanNumeral = string.Format("{0}{1}", leftPlaceValueRomanSymbol, middlePlaceValueRomanSymbol);
            }
            else if (_value == 5)
            {
                romanNumeral = middlePlaceValueRomanSymbol;
            }
            else if (_value >= 6 && _value <= 8)
            {
                romanNumeral += middlePlaceValueRomanSymbol;

                for (int index = 0; index < _value - 5; index++)
                {
                    romanNumeral += leftPlaceValueRomanSymbol;
                }
            }
            else if (_value == 9)
            {
                romanNumeral = string.Format("{0}{1}", leftPlaceValueRomanSymbol, rightPlaceValueRomanSymbol);
            }

            return romanNumeral;
        }

        public int PlaceValue
        {
            get
            {
                return _placeValue;
            }
        }

        public int Value
        {
            get
            {
                return _value;
            }
        }
    }
}
