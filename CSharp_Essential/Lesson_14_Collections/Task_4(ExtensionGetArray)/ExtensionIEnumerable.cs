using System;
using System.Collections.Generic;
using System.Text;
using Task_2;

namespace Task_4_ExtensionGetArray_
{
    public static class ExtensionIEnumerable
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            List<T> tempList = new List<T>();
            foreach (T item in list)
            {
                tempList.Add(item);
            }
            return tempList.ToArray();
        }
    }
}
