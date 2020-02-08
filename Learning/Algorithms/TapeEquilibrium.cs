using System;

namespace Learning.Algorithms
{
    public class TapeEquilibrium
    {
        public int Solution()
        {
            if (elements == null || elements.Length == 0)
                return 0;

            var left = elements[0];
            int right = 0;

            // sum right side
            for (int j = 1; j < elements.Length; j++)
                right += elements[j];

            // test abs sum
            var min = Math.Abs(left - right);

            // sum left side
            for (int k = 1; k < elements.Length - 1; k++)
            {
                left += elements[k];
                right -= elements[k];

                int test = Math.Abs(left - right);
                // take the minimum
                if (test < min)
                    min = test;
            }

            return min;
        }

        public TapeEquilibrium(int[] elements)
        {
            this.elements = elements;
        }

        readonly int[] elements;
    }
}
