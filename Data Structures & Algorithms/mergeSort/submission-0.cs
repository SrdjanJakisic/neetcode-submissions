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
        if(end - start + 1 <= 1) return pairs;

        int middle = (start + end) / 2;

        MergeSortHelper(pairs, start, middle);
        MergeSortHelper(pairs, middle + 1, end);
        Merge(pairs, start, middle, end);

        return pairs;
    }

    public void Merge(List<Pair> array, int start, int middle, int end)
    {
        List<Pair> left = new List<Pair>(array.GetRange(start, middle - start + 1));
        List<Pair> right = new List<Pair>(array.GetRange(middle + 1, end - middle));

        int i = 0;
        int j = 0;
        int k = start;

        while(i < left.Count && j < right.Count)
        {
            if(left[i].Key <= right[j].Key)
            {
                array[k] = left[i];
                i++;
            }
            else
            {
                array[k] = right[j];
                j++;
            }
            k++;
        }

        while(i < left.Count)
        {
            array[k] = left[i];
            i++;
            k++;
        }

        while(j < right.Count)
        {
            array[k] = right[j];
            j++;
            k++;
        }

    }
}
