// Ezra Koppel HW2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO368
{
    public class NumberConversions
    {
        public static string Convert(int x)
        {
            Dictionary<int, string> d = new Dictionary<int, string>
            {
                [0] = "",
                [1] = "one",
                [2] = "two",
                [3] = "three",
                [4] = "four",
                [5] = "five",
                [6] = "six",
                [7] = "seven",
                [8] = "eight",
                [9] = "nine",
                [10] = "ten",
                [11] = "eleven",
                [12] = "twelve",
                [13] = "thirteen",
                [14] = "fourteen",
                [15] = "fifteen",
                [16] = "sixteen",
                [17] = "seventeen",
                [18] = "eighteen",
                [19] = "nineteen",
                [20] = "twenty",
                [30] = "thirty",
                [40] = "forty",
                [50] = "fifty",
                [60] = "sixty",
                [70] = "seventy",
                [80] = "eighty",
                [90] = "ninety",
                [100] = "hundred",
                [1_000] = "thousand"
            };
            if (x < 21)
                return d[x];
            if (x < 100)
                return $"{d[(x / 10) * 10]} {d[x % 10]}";
            if (x < 1_000)
                return $"{Convert(x / 100)} hundred {Convert(x % 100)}";
            return $"{Convert(x / 1_000)} thousand {Convert(x % 1_000)}";
        }
    }
}