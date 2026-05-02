using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class MyList <T>
    {
        private T[] _array;
        private int _index;

        public MyList()
        {
            _array = new T[4];
            _index = 0;
        }

        public int Count => _index;

        public void Add(T item)
        {
            if (_index == _array.Length)
            {
                Resize();
            }
            _array[_index] = item;
            _index++;
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _array.Length) 
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
        }
        private void Resize()
        {
            T[] newArray = new T[_array.Length * 2];
            for (int i =0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

    }
   
}
