using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec2026_Windows_dev_interview_Pattarapong_Banyat.Problems
{
    public class Problem6
    {
        public void Problem6_Function() { }

        public int[] Tribonacci(int[] seed, int n)
        {
            List<int> result = new List<int>(seed);

            if(n <= seed.Length)
            {
                Console.WriteLine(string.Join(", ", result.GetRange(0, n).ToArray()));
                return result.GetRange(0, n).ToArray();
            }

            while (result.Count < n)
            {
                int count = result.Count;

                int next = 0;

                int a1 = count >= 1 ? result[count - 1] : 0;
                int a2 = count >= 2 ? result[count - 2] : 0;
                int a3 = count >= 3 ? result[count - 3] : 0;

                next = a1 + a2 + a3;

                result.Add(next);

                Console.WriteLine(string.Join(", ", result));
            }

            return result.ToArray();
        }

        //public int[]  Tribonacci(int n)
        //{
        //    List<int> result = new List<int> { 0, 1, 1 };
        //    while (result.Count < n)
        //    {
        //        int next = result[result.Count - 1] + result[result.Count - 2] + result[result.Count - 3];
        //        result.Add(next);
        //        Console.WriteLine(string.Join(", ", result));
        //    }
        //    return result.ToArray();
        //}

        //public int[] Fibonacci(int n)
        //{
        //    List<int> result = new List<int> { 1, 1 };

        //    while (result.Count < n)
        //    {
        //        int next = result[result.Count - 1] + result[result.Count - 2];
        //        result.Add(next);
        //        Console.WriteLine(string.Join(", ", result));
        //    }

        //    return result.ToArray();
        //}



    }
}
