using System;

namespace Learning.Algorithms
{
    public class MissingElement
    {

        public int Solution(int[] elements)
        {
            // edge case
            if (elements == null || elements.Length == 0)
                return 0;

            // total number of elements in the series
            long n = elements.Length + 1;

            // we use the fomula n(n+1)/2 this is the pro one
            //long series_total = n * (n + 1) / 2;
            long sum = 0;
            long series_total = 0;
            // without the formula

            for (int i = 1; i <= n; i++)
                series_total += i;

            for (int i = 0; i < n; i++)
                sum += elements[i];
            // actual total in the array
            //long sum = elements.Sum(x => x);

            // difference is the missing number

            return (int)(series_total - sum);
        }

    }

}
