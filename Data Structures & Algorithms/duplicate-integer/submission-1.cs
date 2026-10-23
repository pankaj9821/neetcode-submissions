public class Solution {
    public bool hasDuplicate(int[] nums) {
        int n = nums.Length;
        var hs = new HashSet<int>();
        for(int i=0;i<n;i++){
            if(hs.Contains(nums[i])){
                return true;
            }
            hs.Add(nums[i]);
        }
        return false;
    }
}