public class Solution {
    public int singleNumber(int[] nums) {
    // with Bit Manipulation
      int a = 0;
      for (int i = 0; i < nums.Length; i++)
        a ^= nums[i];
      return a;
    }
}
