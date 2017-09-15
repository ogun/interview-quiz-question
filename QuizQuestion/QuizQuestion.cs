using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizQuestion
{
    public static class QuizQuestion
    {
        public static int BiggestProduct(IList<int> arr, int k)
        {
            if (arr == null) throw new ArgumentNullException(nameof(arr));

            if (k < 0) throw new ArgumentException(nameof(k));

            if (k > arr.Count) throw new ArgumentOutOfRangeException(nameof(k));

            if (k == 0) return 0;

            if (k == 1) return arr.Max();

            var sortedList = arr.OrderByDescending(Math.Abs);
            var biggestList = sortedList.Take(k - 1);
            var others = sortedList.Skip(k - 1);
            var biggest = biggestList.Aggregate(1, (x, y) => x * y);
            if (biggest > 0)
            {
                biggest = biggest * others.Max();
            }
            else
            {
                biggest = biggest * others.Min();
            }

            return biggest;
        }
    }
}
