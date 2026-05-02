using System;
using System.Collections.Generic;
using System.Text;
using Task_2;

namespace Task_4
{
    public static class MyListExtensions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
                array[i] = list[i];
            return array;
        }
    }
}
