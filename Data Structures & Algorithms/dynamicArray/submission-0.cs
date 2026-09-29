public class DynamicArray {
    private int[] _array;
    private int _size;
    private int _capacity;

    public DynamicArray(int capacity) 
    {
        this._capacity = capacity;
        this._size = 0;
        this._array = new int[capacity];
    }

    public int Get(int i) {
        return _array[i];
    }

    public void Set(int i, int n) {
        _array[i] = n;
    }

    public void PushBack(int n) {
        if (_size == _capacity) {
            Resize();
        }
        _array[_size] = n;
        _size++;
    }

    public int PopBack() {
        _size--;
        return _array[_size];
    }

    private void Resize() {
        _capacity = _capacity * 2;
        int[] newArray = new int[_capacity];
        for (int i = 0; i < _size; i++) {
            newArray[i] = _array[i];
        }
        _array = newArray;
    }

    public int GetSize() {
        return _size;
    }

    public int GetCapacity() {
        return _capacity;
    }
}
