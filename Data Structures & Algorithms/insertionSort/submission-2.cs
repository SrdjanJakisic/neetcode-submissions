// Definition for a pair
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
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        int n = pairs.Count;
        List<List<Pair>> res = new List<List<Pair>>();

        if(n == 0) return res;
        res.Add(new List<Pair>(pairs));
        
        for(int i = 1; i < n; i++)
        {
            Pair key = pairs[i];
            int j = i - 1;
            while(j >= 0 && pairs[j].Key > key.Key){
                pairs[j + 1] = pairs[j];
                j--;
            }

            pairs[j + 1] = key;
            res.Add(new List<Pair>(pairs));
        }

        return res;
    }
}
