using persec2026_Windows_dev_interview_Pattarapong_Banyat.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec2026_Windows_dev_interview_Pattarapong_Banyat.Tests
{
    public class Problem6Tests
    {
        [Fact]
        public void Tribonacci_ShouldReturn_Correct_Result_Case1()
        {
            // Arrange
            var problem = new Problem6();
            int[] seed = { 1, 3, 5 };
            int n = 5;
            int[] expected = { 1, 3, 5, 9, 17 };

            // Act
            var result = problem.Tribonacci(seed, n);

            // Assert
            Assert.True(result.SequenceEqual(expected));
        }

        [Fact]
        public void Tribonacci_ShouldReturn_Seed_WhenNEqualSeedLength()
        {
            var problem = new Problem6();

            int[] seed = { 2, 2, 2 };
            int n = 3;
            int[] expected = { 2, 2, 2 };

            var result = problem.Tribonacci(seed, n);

            Assert.True(result.SequenceEqual(expected));
        }

        [Fact]
        public void Tribonacci_ShouldGenerate_Next_Value()
        {
            var problem = new Problem6();

            int[] seed = { 10, 10, 10 };
            int n = 4;
            int[] expected = { 10, 10, 10, 30 };

            var result = problem.Tribonacci(seed, n);

            Assert.True(result.SequenceEqual(expected));
        }
    }
}
