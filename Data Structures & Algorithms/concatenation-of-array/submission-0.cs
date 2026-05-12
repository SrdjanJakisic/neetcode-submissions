public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int capacity = nums.Length;
        int[] ans = new int[2*capacity];
        for(int i = 0; i < capacity; i++)
        {
            ans[i] = nums[i];
            ans[i + nums.Length] = nums[i];
        }

        return ans;
    }
}