using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec2026_Windows_dev_interview_Pattarapong_Banyat.Problems
{
    public class Problem5
    {
        public void Problem5_Function(int number)
        {
            int result = SortDigitsDescending(number);
            Console.WriteLine($"{number} => {result}");
        }

        public int SortDigitsDescending(int number)
        {
            string str = number.ToString();
            var sorted = str
                .OrderByDescending(c => c)
                .ToArray();

            return int.Parse(new string(sorted));
        }
    }
}
