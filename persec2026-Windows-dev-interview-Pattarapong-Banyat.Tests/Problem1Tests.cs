using persec2026_Windows_dev_interview_Pattarapong_Banyat.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec2026_Windows_dev_interview_Pattarapong_Banyat.Tests
{
    public class Problem1Tests
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("([]]", false)]
        [InlineData("([{}])", true)]
        [InlineData("([[{}]]]", false)]
        [InlineData(")", false)]
        [InlineData("(]}])", false)]
        [InlineData("([)]", false)]
        [InlineData("{", false)]
        public void IsValid_ShouldReturnCorrectResult(string input, bool expected)
        {
            // Arrange
            var problem = new Problem1();

            // Act
            bool result = problem.IsValid(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
