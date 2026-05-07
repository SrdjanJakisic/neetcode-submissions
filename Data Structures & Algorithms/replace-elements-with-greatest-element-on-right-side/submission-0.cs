public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length, rightMax = -1;
        int[] ans = new int[n];

        for(int i = n-1; i >= 0; i--)
        {
            ans[i] = rightMax;
            rightMax = Math.Max(arr[i], rightMax);
        }

        return ans;
    }
}