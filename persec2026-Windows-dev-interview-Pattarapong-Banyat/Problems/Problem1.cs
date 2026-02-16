using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec2026_Windows_dev_interview_Pattarapong_Banyat.Problem
{
    public class Problem1
    {
        public void Problem1_Function(string input)
        {
            if (input == null) {
                Console.WriteLine("Input is null");
                return;
            }

            bool isValid = IsValid(input);
            Console.WriteLine($"\"{input}\" => {isValid}");
        }

        public bool IsValid(string input)
        {
            //Console.WriteLine($"Input: {input}");
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (IsOpening(c))
                {
                    //Console.WriteLine($"Pushing: {c}");
                    stack.Push(c);
                    //Console.WriteLine($"Stack now: {string.Join(", ", stack)}");
                }
                else if (IsClosing(c))
                {
                    //Console.WriteLine($"Closing : {c}");
                    if (stack.Count == 0)
                    {
                        //Console.WriteLine("Stack now is empty.");
                        return false;
                    }
                    char top = stack.Peek();
                    if (IsMatchingPair(top, c))
                    {
                        //Console.WriteLine($"Matched: {top}{c}");
                        stack.Pop();
                        //Console.WriteLine($"Stack now: {string.Join(", ", stack)}");
                    }
                    else
                    {
                        //Console.WriteLine($"Mismatch: {top}{c}");
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        private bool IsOpening(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        private bool IsClosing(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        private bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '[' && close == ']') ||
                   (open == '{' && close == '}');
        }
    }
}
