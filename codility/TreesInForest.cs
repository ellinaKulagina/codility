// TASK DESCRIPTION
// There are N trees in a forest, the K-th tree is located at coordinates (X(K), Y(K))
// We want to build the widest possible vertical path, such that there is o tree on it
// Write a function to return the width of the widest posible path

using System.Collections.Generic;
using System.Linq;

namespace codility
{
    class TreesInForest
    {
        public static int GetWidestPath(int[] trees)
        {
            List<int> sortedDots = new List<int>(trees);
            sortedDots = sortedDots.Distinct().ToList();
            sortedDots.Sort();
            int width = 1;

            if (sortedDots.Count > 1)
            {
                for (int i = 0; i < sortedDots.Count - 1; i++)
                {
                    int delta = sortedDots[i + 1] - sortedDots[i];
                    if (delta > width)
                        width = delta;
                }
            }

            return width;
        }
    }
}
