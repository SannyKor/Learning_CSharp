using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task_3_MyDictionary
{
    public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        int count;
        KeyValuePair<TKey, TValue>[] array;
        public int Count => count;  
        public MyDictionary() 
        { 
            array = new KeyValuePair<TKey, TValue>[4];
        }
        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (EqualityComparer<TKey>.Default.Equals(array[i].Key, key))
                    {
                        return array[i].Value;
                    }
                }
                throw new KeyNotFoundException($"Ключ '{key}' не знайдено.");
            }
        }
        public void Add(TKey key, TValue value)
        {
            if (count == array.Length)
            {
                Array.Resize(ref array, array.Length * 2);
            }
            array[count++] = new KeyValuePair<TKey, TValue>(key, value);
        }
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
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
