public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int,int>();
        for(int i = 0; i<nums.Length; i++){
            int othr = target - nums[i];
            if(seen.ContainsKey(othr)){
                return new int[] {seen[othr],i};
            }
            seen.Add(nums[i],i);
        }
        return new int[]{0,0};
       }
}
