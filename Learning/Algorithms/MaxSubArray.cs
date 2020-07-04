public class MaxSubArray {
    public int Solve(int[] nums) {
       
        int n = nums.Length;
        int currentSum = nums[0];
        int maxSum = nums[0];
        
        for (int i = 1; i < n; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }
        
        return maxSum;
    }
}
