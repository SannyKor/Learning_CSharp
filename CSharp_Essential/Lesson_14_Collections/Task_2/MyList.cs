using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Quic;
using System.Text;

namespace Task_2
{
    public class MyList<T> : IEnumerable<T>
    {
        int count;
        T[] array;
        public int Count => count;
        public MyList()
        {
            array = new T[4];
            count = 0;
        }
        public void Add(T item)
        {
            if (count <= array.Length)
                array[count++] = item;
            else
            {
                Resize();
                array[count++] = item;
            }
        }
        private void Resize()
        {
            T[] newArray = new T[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        public  T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();
                return array[index];
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
