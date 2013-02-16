
namespace RomanNumerals
{
    public class DigitsGenerator
    {
        public Digit[] Generate(int number)
        {
            var characters = number
                .ToString()
                .ToCharArray();

            var digits = new Digit[characters.Length];

            for (int index = 0; index < digits.Length; index++)
            {
                digits[index] = new Digit(characters[index], index, digits.Length);
            }

            return digits;
        }
    }
}
