// TASK DESCRIPTION:
// Write a function that, given an array A of N integers, 
// returns the smallest positive integer (greater than 0) that does not occur in A.
using System.Collections.Generic;

namespace codility
{
    class SampleTest
    {
        public static int GetNumber(int[] testData)
        {
            List<int> sorted = new List<int>();
            foreach (int el in testData)
            {
                if (el > 0)
                    sorted.Add(el);
            }

            int size = sorted.Count;

            if (size == 0)
            {
                return 1;
            }

            sorted.Sort();

            if (sorted[0] != 1)
            {
                return 1;
            }

            for (int i = 0; i < size - 1; i++)
            {
                if (sorted[i + 1] - sorted[i] > 1)
                    return sorted[i] + 1;
            }

            return sorted[size - 1] + 1;
        }
    }
}
