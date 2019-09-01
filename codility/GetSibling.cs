// TASK DESCRIPTION
// Write a function that given a non-negative integer N, returns the largest number in the family of N

using System.Collections.Generic;
using System.Linq;

namespace codility
{
    class GetSibling
    {
        public static int GetSiblingThroughString(int number)
        {
            var something = number.ToString().ToList();
            something.Sort();
            something.Reverse();

            return int.Parse(string.Join("", something));
        }

        public static int GetSiblingWithoutConverting(int number)
        {
            List<int> list = new List<int>();
            while (number > 0)
            {
                list.Add(number % 10);
                number /= 10;
            }

            list.Sort();
            list.Reverse();

            int sibling = 0;
            foreach (int digit in list)
            {
                sibling = 10 * sibling + digit;
            }

            return sibling;
        }
    }
}
