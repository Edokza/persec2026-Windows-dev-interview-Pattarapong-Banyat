using persec2026_Windows_dev_interview_Pattarapong_Banyat.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec2026_Windows_dev_interview_Pattarapong_Banyat.Tests
{
    public class Problem4Tests
    {
        [Theory]
        [InlineData(1989, "MCMLXXXIX")]
        [InlineData(2000, "MM")]
        [InlineData(68, "LXVIII")]
        [InlineData(109, "CIX")]
        public void IntToRoman_ShouldReturnCorrectResult(int input, string expected)
        {
            // Arrange
            var problem = new Problem4();

            // Act
            var result = problem.IntToRoman(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("MCMLXXXIX", 1989)]
        [InlineData("MM", 2000)]
        [InlineData("LXVIII", 68)]
        [InlineData("CIX", 109)]
        public void RomanToInt_ShouldReturnCorrectResult(string input, int expected)
        {
            // Arrange
            var problem = new Problem4();

            // Act
            var result = problem.RomanToInt(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
