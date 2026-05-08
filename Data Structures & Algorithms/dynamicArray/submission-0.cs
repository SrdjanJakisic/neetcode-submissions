public class DynamicArray {
    
    int capacity, length;
    int[] arr;

    public DynamicArray(int capacity) {
        this.capacity = capacity;
        this.length = 0;
        this.arr = new int[capacity];
    }

    public int Get(int i) {
        return arr[i];
    }

    public void Set(int i, int n) {
        arr[i] = n;
    }

    public void PushBack(int n) {
        if(length == capacity)
            this.Resize();

        arr[length] = n;
        length++;
    }

    public int PopBack() {
        length--;
        return arr[length];
    }

    private void Resize() {
        capacity = 2 * capacity;
        int[] newArr = new int[capacity];
        for(int i = 0; i < length; i++)
            newArr[i] = arr[i];
        arr = newArr;
    }

    public int GetSize() {
        return length;
    }

    public int GetCapacity() {
        return capacity;
    }
}
