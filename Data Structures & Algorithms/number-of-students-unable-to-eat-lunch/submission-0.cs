public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> studentsQueue = new Queue<int>(students);
        Stack<int> availSandwitches = new Stack<int>();
        for(int i = sandwiches.Length-1; i >= 0; i--) availSandwitches.Push(sandwiches[i]);

        int count = 0;
        while(count < studentsQueue.Count())
        {
            if(studentsQueue.Peek() == availSandwitches.Peek())
            {
                studentsQueue.Dequeue();
                availSandwitches.Pop();
                count = 0;
            }
            else
            {
                studentsQueue.Enqueue(studentsQueue.Dequeue());
                count++;
            }
        }

        return studentsQueue.Count();
    }
}