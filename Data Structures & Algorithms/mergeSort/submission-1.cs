// public class Pair {
//     public int Key;
//     public string Value;

//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }

public class Solution {
    // Implementation of MergeSort
    public List<Pair> MergeSort(List<Pair> pairs) {
        return MergeSortHelper(pairs, 0, pairs.Count - 1);
    }

    public List<Pair> MergeSortHelper(List<Pair> pairs, int start, int end)
    {
        if(start >= end) return pairs;

        int mid = (start + end) / 2;

        MergeSortHelper(pairs, start, mid);
        MergeSortHelper(pairs, mid + 1, end);
        Merge(pairs, start, mid, end);

        return pairs;
    }
    
    public void Merge(List<Pair> pairs, int start, int mid, int end)
    {
        List<Pair> leftArr = new List<Pair>(pairs.GetRange(start, mid - start + 1));
        List<Pair> rightArr = new List<Pair>(pairs.GetRange(mid + 1, end - mid));

        int leftIndex = 0;
        int rightIndex = 0;
        int index = start;

        while(leftIndex < leftArr.Count && rightIndex < rightArr.Count)
        {
            if(leftArr[leftIndex].Key <= rightArr[rightIndex].Key)
            {
                pairs[index] = leftArr[leftIndex];
                leftIndex++;
                index++;
            }
            else
            {
                pairs[index] = rightArr[rightIndex];
                rightIndex++;
                index++;
            }
        }

        while(leftIndex < leftArr.Count)
        {
            pairs[index] = leftArr[leftIndex];
            leftIndex++;
            index++;
        }

        while(rightIndex < rightArr.Count)
        {
            pairs[index] = rightArr[rightIndex];
            rightIndex++;
            index++;
        }
    }
    
}
