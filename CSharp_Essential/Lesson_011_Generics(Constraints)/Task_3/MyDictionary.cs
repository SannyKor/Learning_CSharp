using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public class MyDictionary <TKey, TValue>
    {
        private List<TKey> keys = new List<TKey>();
        private List<TValue> values = new List<TValue>();
        
        public int Count => keys.Count;
        public TValue this[TKey key]
        {
            get
            {
                int index = GetIndexByKey(key);
                return values[index];
            }
        }
        public void Add(TKey key, TValue value)
        {
            if (keys.Contains(key))
                throw new ArgumentException("Такий ключ вже існує");
            keys.Add(key);
            values.Add(value);
        }
        public void Remove(TKey key)
        {
            int index = GetIndexByKey(key);
            keys.RemoveAt(index);
            values.RemoveAt(index);
        }
        private int GetIndexByKey(TKey key)
        {
            int index = keys.IndexOf(key);
            if (index == -1)
                throw new ArgumentException("Такий ключ не існує");
            return index;
        }
           
    }
}
