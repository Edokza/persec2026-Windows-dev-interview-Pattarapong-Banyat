using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec2026_Windows_dev_interview_Pattarapong_Banyat.Problems
{
    public class Problem2
    {
        public void Problem2_Function(string[] input)
        {
            if (input == null)
            {
                Console.WriteLine("Input is null");
                return;
            }

            string[] sorted = Sort(input);

            Console.WriteLine($"{string.Join(", ", input)} => {string.Join(", ", sorted)}");

        }

        public string[] Sort(string[] input)
        {
            input = input.OrderBy(x => SplitFormat(x).prefix)
                         .ThenBy(x => SplitFormat(x).number)
                         .ToArray();

            return input;
        }

        private (string prefix, int number) SplitFormat(string value)
        {
            string prefix = "";
            string number = "";

            foreach (char c in value)
            {
                if (char.IsLetter(c) && number == "")
                {
                    prefix += c;
                }
                else if (char.IsDigit(c))
                {
                    number += c;
                }
                else
                {
                    break;
                }
            }

            //Console.WriteLine($"Value: {value}");
            //Console.WriteLine($"Prefix: {prefix}");
            //Console.WriteLine($"Number: {number}");


            return (prefix, int.Parse(number));
        }
    }
}
