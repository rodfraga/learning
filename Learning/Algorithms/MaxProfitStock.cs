using System;

namespace Learning.Algorithms
{
    public class MaxProfitStock
    {
        public int Solution(int[] A)
        {
            if (A.Length == 0) return 0;

            int min = A[0]; //mainin the previous min price
            int profit = 0; //current max profit
            for (int i = 1; i < A.Length; i++)
            {
                min = Math.Min(min, A[i]); //update minimum
                profit = Math.Max(profit, A[i] - min); //calculate current profit
            }
            return profit > 0 ? profit : 0;
        }
    }
}
