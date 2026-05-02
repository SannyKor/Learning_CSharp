using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    public class MyArrayList
    {
        object[] array;
        int count;
        int defaultSize = 4;
        public MyArrayList()
        {
            array = new object[defaultSize];
            count = 0;
            Console.WriteLine("Створено колекцію myArrayList");
        }
        public int Count => count;
        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();
                return array[index];
            }
            set
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();
                array[index] = value;
            }
        }
        public void Add(object item)
        {
            if (count == array.Length)
            {
                Resize();
            }
            array[count] = item;
            count++;
        }
        private void Resize()
        {
            int newSize = array.Length * 2;
            object[] newArray = new object[newSize];
            Array.Copy(array, newArray, array.Length);
            array = newArray;
        }
    }
}
