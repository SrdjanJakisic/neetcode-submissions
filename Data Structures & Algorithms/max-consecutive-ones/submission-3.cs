public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int current = 0;
        int previous = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 1)
                current++;
            else
            {
                if(current > previous)
                    previous = current;
                current = 0;
            }
        }
        return Math.Max(current, previous);
    }
}