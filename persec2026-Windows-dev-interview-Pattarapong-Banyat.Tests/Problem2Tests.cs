using persec2026_Windows_dev_interview_Pattarapong_Banyat.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec2026_Windows_dev_interview_Pattarapong_Banyat.Tests
{
    public class Problem2Tests
    {
        [Theory]
        [InlineData(new string[] { "TH19", "SG20", "TH2" },
                    new string[] { "SG20", "TH2", "TH19" })]

        [InlineData(new string[] { "TH10", "TH3Netflix", "TH1", "TH7" },
                    new string[] { "TH1", "TH3Netflix", "TH7", "TH10" })]
        public void Sort_ShouldReturnCorrectResult(string[] input, string[] expected)
        {
            // Arrange
            var problem = new Problem2();

            // Act
            var result = problem.Sort(input);

            // Assert
            Assert.True(result.SequenceEqual(expected));
        }
    }
}
