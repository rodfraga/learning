using System;
namespace Learning.Algorithms
{
    public class Fibonacci
    {
        public int Tabular(int n)
        {
            int[] values = new int[n + 1];

            // Change this as follows to solve the stairs climbing problem for 1 or 2 steps
            // values[1] = 1
            // vaklues[2] = 2
            // and update the start index to; int index = 3 in for loop.
            values[0] = 0; 
            values[1] = 1; 

            for (int index = 2; index <= n; index++)
                values[index] = values[index - 1] + values[index - 2];

            return values[n];
        }
    }
}
