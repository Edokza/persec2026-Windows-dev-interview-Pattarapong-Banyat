using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec2026_Windows_dev_interview_Pattarapong_Banyat.Problems
{
    public class Problem4
    {
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

            result += ConvertDigit(hundreds, "C", "D", "M");
            result += ConvertDigit(tens, "X", "L", "C");
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

    }
}
