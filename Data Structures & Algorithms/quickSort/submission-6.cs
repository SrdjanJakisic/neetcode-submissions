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

    private void QuickSortHelper(List<Pair> array, int start, int end)
    {
        if(start >= end) return;

        Pair pivot = array[end];
        int left = start;

        for(int i = start; i < end; i++)
        {
            if(array[i].Key < pivot.Key)
            {
                Pair temp = array[left];
                array[left] = array[i];
                array[i] = temp;
                left++;
            }
        }

        array[end] = array[left];
        array[left] = pivot;

        QuickSortHelper(array, start, left-1);
        QuickSortHelper(array, left+1, end);
    }

    

    
}
