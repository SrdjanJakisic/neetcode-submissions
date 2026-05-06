public class Solution {
    public int RemoveElement(int[] nums, int val) {
        // int k = 0;

        // for(int i = 0; i < nums.Length; i++)
        // {
        //     if(nums[i] != val)
        //         nums[k++] = nums[i];
        // }

        // return k;

        int i = 0, n = nums.Length;

        while(i < n)
        {
            if(nums[i] == val)
                nums[i] = nums[--n];
            else
                i++;
        }

        return n;
    }
}