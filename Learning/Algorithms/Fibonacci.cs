using System;
namespace Learning.Algorithms
{
    public class Fibonacci
    {
        public int Tabular(int n)
        {
            int[] values = new int[n + 1];

            values[0] = 0;
            values[1] = 0;

            for (int index = 2; index <= n; index++)
                values[index] = values[index - 1] + values[index - 2];

            return values[n];
        }
    }
}
