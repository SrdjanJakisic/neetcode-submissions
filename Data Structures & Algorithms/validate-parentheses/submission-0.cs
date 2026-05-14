public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> hashMap = new Dictionary<char, char>
        {
            { ')', '('},
            {'}', '{'},
            {']', '['}
        };

        foreach(char c in s)
        {
            if(hashMap.ContainsKey(c))
                if(stack.Count > 0 && stack.Peek() == hashMap[c])
                    stack.Pop();
                else
                    return false;
            else
                stack.Push(c);
        }

        return stack.Count == 0;
    }
}
