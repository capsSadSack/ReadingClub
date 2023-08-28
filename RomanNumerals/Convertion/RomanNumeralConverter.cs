using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertion
{
    public static class RomanNumeralConverter
    {
        private static readonly Dictionary<char, int> _romanNumerals = 
            new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static int ToArabic(string romanNumber)
        {
            if (!AllSymbolsAreRoman(romanNumber))
            {
                throw new ArgumentException("String contains not supported symbols.");
            }

            if (romanNumber.Count() == 1)
            {
                return _romanNumerals[romanNumber[0]];
            }

            int maxNumberIndex = GetMaxNumberIndex(romanNumber);
            int maxNumber = ToArabic(romanNumber.Substring(maxNumberIndex, 1));

            if (maxNumberIndex == 0)
            {
                return maxNumber + ToArabic(romanNumber.Substring(maxNumberIndex + 1));
            }
            else if (maxNumberIndex == romanNumber.Length - 1)
            {
                return maxNumber - ToArabic(romanNumber.Substring(0, romanNumber.Length - 1));
            }
            else
            {
                return maxNumber - ToArabic(romanNumber.Substring(0, maxNumberIndex)) + ToArabic(romanNumber.Substring(maxNumberIndex + 1));
            }
        }

        private static bool AllSymbolsAreRoman(string romanNumber)
        {
            return romanNumber.All(ch => _romanNumerals.Keys.Contains(ch));
        }

        private static int GetMaxNumberIndex(string romanNumber)
        {
            var orderedNumerals = _romanNumerals
                .OrderByDescending(x => x.Value);

            foreach(var item in orderedNumerals)
            {
                if(romanNumber.Contains(item.Key))
                {
                    return romanNumber.IndexOf(item.Key);
                }
            }

            throw new ArgumentException("Roman number format is wrong");
        }
    }
}
