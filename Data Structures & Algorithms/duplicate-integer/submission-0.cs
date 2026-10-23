public class Solution {
    public bool hasDuplicate(int[] nums) {
        int n = nums.Length;
        Array.Sort(nums);
        for(int i = 1;i<n;i++)
        {
        if(nums[i]==nums[i-1]){
            return true;
        }
        }
            return false;
    }
}