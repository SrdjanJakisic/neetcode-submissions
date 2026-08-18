public class Solution {

    public static void MergeSortImplementation(int[] arr, int start, int end)
    {
        if(start >= end) return;

        int mid = (start + end) / 2;

        MergeSortImplementation(arr, start, mid);
        MergeSortImplementation(arr, mid + 1, end);
        MergeSort(arr, start, mid, end);
    }

    public static void MergeSort(int[] arr, int start, int mid, int end)
    {
        int leftSize = mid - start + 1;
        int rightSize = end - mid;

        int[] leftArr = new int[leftSize];
        int[] rightArr = new int[rightSize];

        for(int i = 0; i < leftSize; i++) leftArr[i] = arr[start + i];
        for(int i = 0; i < rightSize; i++) rightArr[i] = arr[mid + 1 + i];

        int leftIndex = 0;
        int rightIndex = 0;
        int k = start;

        while(leftIndex < leftSize && rightIndex < rightSize)
        {
            if(leftArr[leftIndex] <= rightArr[rightIndex])
            {
                arr[k] = leftArr[leftIndex];
                k++;
                leftIndex++;
            }
            else
            {
                arr[k] = rightArr[rightIndex];
                k++;
                rightIndex++;
            }
        }

        while(leftIndex < leftSize)
        {
            arr[k] = leftArr[leftIndex];
            k++;
            leftIndex++;
        }

        while(rightIndex < rightSize)
        {
            arr[k] = rightArr[rightIndex];
            k++;
            rightIndex++;
        }

    }

    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        for(int i = 0; i < n; i++) nums1[i + m] = nums2[i];

        MergeSortImplementation(nums1, 0, nums1.Length - 1);
    }
} 