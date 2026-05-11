public class DynamicArray {
    
    int _capacity, _length;
    int[] _arr;

    public DynamicArray(int capacity) {
        _capacity = capacity;
        _length = 0;
        _arr = new int[capacity];
    }

    public int Get(int i) {
        if(i < 0 || i >= _length)
            throw new IndexOutOfRangeException();
        
        return _arr[i];
    }

    public void Set(int i, int n) {
        if(i < 0 || i >= _length)
            throw new IndexOutOfRangeException();
        _arr[i] = n;
    }

    public void PushBack(int n) {
        if(_length == _capacity)
            Resize();

        _arr[_length] = n;
        _length++;
    }

    public int PopBack() {
        _length--;
        return _arr[_length];
    }

    private void Resize() {
        _capacity = 2 * _capacity;
        int[] newArr = new int[_capacity];
        for(int i = 0; i < _length; i++)
            newArr[i] = _arr[i];

        _arr = newArr;
    }

    public int GetSize() {
        return _length;
    }

    public int GetCapacity() {
        return _capacity;
    }
}
