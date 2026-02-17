
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

            Console.WriteLine("Run Problem 1");

            var problem1 = new Problem1();

            problem1.Problem1_Function("()");
            problem1.Problem1_Function("([]]");
            problem1.Problem1_Function("([[{}]]]");
            problem1.Problem1_Function(")");
            problem1.Problem1_Function("{");

            Console.WriteLine("=======================================================================");

            #endregion

            #region Run Problem 2

            // Run Problem 2

            Console.WriteLine("Run Problem 2");

            var p2 = new Problem2();

            p2.Problem2_Function(new string[] { "TH19", "SG20", "TH2" });
            p2.Problem2_Function(new string[] { "TH10", "TH3Netflix", "TH1", "TH7" });

            Console.WriteLine("=======================================================================");

            #endregion

            #region Run Problem 3
            // Run Problem 3

            Console.WriteLine("Run Problem 3");

            var p3 = new Problem3();

            string search = "th";

            string[] items =
            {
                "Mother",
                "Think",
                "Worthy",
                "Apple",
                "Android"
            };

            int maxResult = 2;

            p3.Problem3_Function(search, items, maxResult);

            Console.WriteLine("=======================================================================");

            #endregion

            #region Run Problem 4

            // Run Problem 4

            Console.WriteLine("Run Problem 4");

            var p4 = new Problem4();

            p4.Problem4_Function1(1989);
            p4.Problem4_Function1(2000);
            p4.Problem4_Function1(68);
            p4.Problem4_Function1(109);

            p4.Problem4_Function2("MCMLXXXIX");
            p4.Problem4_Function2("MM");
            p4.Problem4_Function2("LXVIII");
            p4.Problem4_Function2("CIX");


            Console.WriteLine("=======================================================================");

            #endregion

            #region Run Problem 5

            // Run Problem 5

            Console.WriteLine("Run Problem 5");

            var p5 = new Problem5();

            p5.Problem5_Function(3008);
            p5.Problem5_Function(1989);
            p5.Problem5_Function(2679);
            p5.Problem5_Function(9163);

            Console.WriteLine("=======================================================================");

            #endregion

            #region Run Problem 6

            // Run Problem 6
            var p6 = new Problem6();
            // ===== CASE 1 =====
            int[] seed1 = { 1, 3, 5 };
            p6.Problem6_Function(seed1, 5);

            // ===== CASE 2 =====
            int[] seed2 = { 2, 2, 2 };
            p6.Problem6_Function(seed2, 3);

            // ===== CASE 3 =====
            int[] seed3 = { 10, 10, 10 };
            p6.Problem6_Function(seed3, 4);

        #endregion

        }
    }
}
