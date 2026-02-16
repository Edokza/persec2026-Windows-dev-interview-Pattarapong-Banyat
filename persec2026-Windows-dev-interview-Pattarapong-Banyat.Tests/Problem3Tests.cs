using persec2026_Windows_dev_interview_Pattarapong_Banyat.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec2026_Windows_dev_interview_Pattarapong_Banyat.Tests
{
    public class Problem3Tests
    {
        [Fact]
        public void Autocomplete_ShouldReturnCorrectResult()
        {
            // Arrange
            var problem = new Problem3();

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

            string[] expected =
            {
                "Think",
                "Mother"
            };

            // Act
            var result = problem.Autocomplete(search, items, maxResult);

            // Assert
            Assert.True(result.SequenceEqual(expected));
        }
    }
}
