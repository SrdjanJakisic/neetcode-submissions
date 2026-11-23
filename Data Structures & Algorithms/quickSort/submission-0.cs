// public class Pair {
//     public int Key;
//     public string Value; 
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<Pair> QuickSort(List<Pair> pairs) {
        QuickSortHelper(pairs, 0, pairs.Count-1);
        return pairs;
    }

    private void QuickSortHelper(List<Pair> arr, int start, int end)
    {
        if(end - start + 1 <= 1) return;
        
        Pair pivot = arr[end];
        int left = start;

        for(int i = start; i < end; i++)
        {
            if(arr[i].Key < pivot.Key)
            {
                Pair temp = arr[left];
                arr[left] = arr[i];
                arr[i] = temp;
                left++;
            }
        }

        arr[end] = arr[left];
        arr[left] = pivot;

        QuickSortHelper(arr, start, left -1);
        QuickSortHelper(arr, left + 1, end);
    }
}
