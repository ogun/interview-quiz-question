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

            // TODO

            return 0;
        }
    }
}
