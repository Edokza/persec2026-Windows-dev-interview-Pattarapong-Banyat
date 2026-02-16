using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec2026_Windows_dev_interview_Pattarapong_Banyat.Problems
{
    public class Problem3
    {
        public void Problem3_Function(string search, string[] items, int maxResult)
        {
            if (search == null || items == null)
            {
                Console.WriteLine("Input is null");
                return;
            }

            string[] result = Autocomplete(search, items, maxResult);

            Console.WriteLine($"Search: {search} items: {string.Join(", ", items)}  MaxResult: {maxResult}");
            Console.WriteLine($"Result: {string.Join(", ", result)}");
        }

        public string[] Autocomplete(string search, string[] items, int maxResult)
        {
            List<(string word, int index)> matchedItems = findMatched(search, items);

            matchedItems = matchedItems.OrderBy(x => x.index).ToList();

            matchedItems = matchedItems.Take(maxResult).ToList();

            return items = matchedItems.Select(x => x.word).ToArray();
        }

        private List<(string word, int index)> findMatched(string search, string[] items)
        {
            List<(string word, int index)> result = new List<(string, int)>();

            foreach (string item in items)
            {
                int index = item.IndexOf(search, StringComparison.OrdinalIgnoreCase);
                if (index >= 0)
                {
                    result.Add((item, index));
                }
            }

            return result;
        }

    }
}
