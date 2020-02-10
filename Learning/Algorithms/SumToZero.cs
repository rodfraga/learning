using System.Collections.Generic;

namespace Learning.Algorithms
{
    public class SumToZero
    {
        public static int[] FindSets(int n)
        {
            if (n == 0)
                return new int[0];

            int[] elements = new int[n];

            int size = n;

            for (int i = 0; i < size / 2; i++)
            {
                elements[i] = (i + 1) * -1;
            }

            if (n % 2 != 0)
            {
                for (int i = size / 2; i < size; i++)
                {
                    elements[i] = i - (size / 2);
                }
            }
            else
            {
                for (int i = size / 2; i < size; i++)
                {
                    elements[i] = i - ((size / 2) - 1);
                }
            }

            return elements;
        }

        public static int[] FindSetsUsingList(int n)
        {
            var list = new List<int>();
            int arrayHalf = n / 2;
            for (int i = -arrayHalf; i <= arrayHalf; i++)
            {
                list.Add(i);
            }

            if (n % 2 == 0)
            {
                list.Remove(0);
            }

            return list.ToArray();
        }

    }
}
