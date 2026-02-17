
using persec2026_Windows_dev_interview_Pattarapong_Banyat.Problem;
using persec2026_Windows_dev_interview_Pattarapong_Banyat.Problems;

namespace InterviewProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project Ready");

            #region Run Problem 1

            // Run Problem 1
            //var problem1 = new Problem1();

            //problem1.Problem1_Function("()");
            //problem1.Problem1_Function("([]]");
            //problem1.Problem1_Function("([[{}]]]");
            //problem1.Problem1_Function(")");
            //problem1.Problem1_Function("{");

            #endregion

            #region Run Problem 2

            // Run Problem 2
            //var p2 = new Problem2();

            //p2.Problem2_Function(new string[] {"TH19", "SG20", "TH2"});
            //p2.Problem2_Function(new string[] {"TH10", "TH3Netflix", "TH1", "TH7" });

            #endregion

            #region Run Problem 3
            // Run Problem 3
            //var p3 = new Problem3();

            //string search = "th";

            //string[] items =
            //{
            //    "Mother",
            //    "Think",
            //    "Worthy",
            //    "Apple",
            //    "Android"
            //};

            //int maxResult = 2;

            //p3.Problem3_Function(search, items, maxResult);

            #endregion

            #region Run Problem 4

            // Run Problem 4
            var p4 = new Problem4();

            //Console.WriteLine(p4.IntToRoman_Mod(1989));
            //Console.WriteLine(p4.IntToRoman_Mod(2000));
            //Console.WriteLine(p4.IntToRoman_Mod(68));
            //Console.WriteLine(p4.IntToRoman_Mod(109));

            Console.WriteLine(p4.RomanToInt("MCMLXXXIX"));
            Console.WriteLine(p4.RomanToInt("MM"));
            Console.WriteLine(p4.RomanToInt("LXVIII"));
            Console.WriteLine(p4.RomanToInt("CIX"));

            #endregion
        }
    }
}
