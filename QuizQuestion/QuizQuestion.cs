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

            var allCombinations = ItemCombinations<int>(arr, k, k);

            var biggest = int.MinValue;
            allCombinations.ForEach(c => biggest = Math.Max(biggest, c.Aggregate(1, (x, y) => x * y)));
            return biggest;
        }

        /// <summary>
        /// Method to create lists containing possible combinations of an input list of items. This is 
        /// basically copied from code by user "jaolho" on this thread:
        /// http://stackoverflow.com/questions/7802822/all-possible-combinations-of-a-list-of-values
        /// </summary>
        /// <typeparam name="T">type of the items on the input list</typeparam>
        /// <param name="inputList">list of items</param>
        /// <param name="minimumItems">minimum number of items wanted in the generated combinations, 
        ///                            if zero the empty combination is included</param>
        /// <param name="maximumItems">maximum number of items wanted in the generated combinations</param>
        /// <returns>list of lists for possible combinations of the input items</returns>
        public static List<List<T>> ItemCombinations<T>(IList<T> inputList, int minimumItems, int maximumItems)
        {
            var nonEmptyCombinations = (int)Math.Pow(2, inputList.Count) - 1;
            var listOfLists = new List<List<T>>(nonEmptyCombinations + 1);

            if (minimumItems == 0)  // Optimize default case
                listOfLists.Add(new List<T>());

            for (int i = 1; i <= nonEmptyCombinations; i++)
            {
                var thisCombination = new List<T>(inputList.Count);
                for (var j = 0; j < inputList.Count; j++)
                {
                    if ((i >> j & 1) == 1)
                        thisCombination.Add(inputList[j]);
                }

                if (maximumItems >= thisCombination.Count && thisCombination.Count >= minimumItems)
                    listOfLists.Add(thisCombination);
            }

            return listOfLists;
        }
    }
}
