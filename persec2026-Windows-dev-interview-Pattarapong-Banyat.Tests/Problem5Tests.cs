using persec2026_Windows_dev_interview_Pattarapong_Banyat.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec2026_Windows_dev_interview_Pattarapong_Banyat.Tests
{
    public class Problem5Tests
    {
        [Theory]
        [InlineData(3008, 8300)]
        [InlineData(1989, 9981)]
        [InlineData(2679, 9762)]
        [InlineData(9163, 9631)]
        public void SortDigitsDescending_ShouldReturnCorrectResult(int input, int expected)
        {
            // Arrange
            var problem = new Problem5();

            // Act
            var result = problem.SortDigitsDescending(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
