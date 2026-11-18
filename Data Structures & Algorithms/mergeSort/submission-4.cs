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

        int middle = (start + end) / 2;
        
        MergeSortHelper(pairs, start, middle);
        MergeSortHelper(pairs, middle + 1, end);
        Merge(pairs, start, middle, end);

        return pairs;
    }

    public void Merge(List<Pair> array, int start, int middle, int end)
    {
        List<Pair> leftArray = new List<Pair>(array.GetRange(start, middle - start + 1));
        List<Pair> rightArray = new List<Pair>(array.GetRange(middle + 1, end - middle));

        int i = 0;
        int j = 0;
        int k = start;

        while(i < leftArray.Count && j < rightArray.Count)
        {
            if(leftArray[i].Key <= rightArray[j].Key) array[k++] = leftArray[i++];
            else array[k++] = rightArray[j++];
        }

        while(i < leftArray.Count) array[k++] = leftArray[i++];
        while(j < rightArray.Count) array[k++] = rightArray[j++];
    }
}
