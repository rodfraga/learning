using System;
namespace Learning.Algorithms
{
    public class BinarySearch
    {
        public static object Recursive(int[] nums, int key, int min, int max)
        {
            if (min > max)
                return null;
            
            int mid = (min + max) / 2;
            
            if (key == nums[mid])
                return mid += 1;
                
            if (key < nums[mid])
                return Recursive(nums, key, min, mid - 1);
            else
                return Recursive(nums, key, mid + 1, max);
            
        }
    }
}
