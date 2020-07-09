using System;

namespace Learning.Algorithms
{
    public class MaxProfitStock
    {
        public int Solution(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int min = prices[0]; //mainin the previous min price
            int profit = 0; //current max profit
            for (int i = 1; i < prices.Length; i++) {
                min = Math.Min(min, prices[i]); //update minimum
                profit = Math.Max(profit, prices[i] - min); //calculate current profit
            }
            return profit > 0 ? profit : 0;
        }
        
        
        public int SolutionMultipleTransactions(int[] prices)
        {
            if(prices == null || prices.Length == 0)
                return 0;
            
            // max profit multiples transactions
            var diff = 0;
            for(int i = 1; i < prices.Length; i++) {
                if(prices[i] > prices[i - 1])
                    diff += prices[i] - prices[i - 1];
            }

            return diff < 0 ? 0 : diff;
        }
    }
}
