public class TwoSumProblem {
    public int[] Solve(int[] nums, int target) {
        
        Dictionary<int,int> map = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length; i++){
            int compliment = target - nums[i];
            if(map.ContainsKey(compliment)){
                return new int[]{map[compliment],i};
            }
            else{
                if(!map.ContainsKey(nums[i]))
                        map.Add(nums[i],i);
            }
        }
        return null;
    }
}
