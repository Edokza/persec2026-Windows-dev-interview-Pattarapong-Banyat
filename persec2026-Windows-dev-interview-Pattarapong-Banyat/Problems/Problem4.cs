using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec2026_Windows_dev_interview_Pattarapong_Banyat.Problems
{
    public class Problem4
    {
        #region IntToRoman
        public string IntToRoman_Mod(int number)
        {
            int thousands = number / 1000;
            int hundreds = (number % 1000) / 100;
            int tens = (number % 100) / 10;
            int ones = number % 10;

            string result = "";

            // thousands
            for (int i = 0; i < thousands; i++)
            {
                result += "M";
            }
            // hundreds
            result += ConvertDigit(hundreds, "C", "D", "M");
            //tens
            result += ConvertDigit(tens, "X", "L", "C");
            //ones
            result += ConvertDigit(ones, "I", "V", "X");

            return result;
        }

        private string ConvertDigit(int digit, string one, string five, string ten)
        {
            if (digit == 9)
                return one + ten;

            if (digit >= 5)
                return five + new string(one[0], digit - 5);

            if (digit == 4)
                return one + five;

            return new string(one[0], digit);
        }

        #endregion

        #region RomanToInt

        public int RomanToInt(string roman)
        {
            Dictionary<char, int> map = new Dictionary<char, int>
            {
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000}
            };

            int total = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                int current = map[roman[i]];

                if (i + 1 < roman.Length &&
                    current < map[roman[i + 1]])
                {
                    total -= current;
                }
                else
                {
                    total += current;
                }
            }

            return total;
        }
        #endregion

    }
}
