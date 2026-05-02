using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3_MyDictionary
{
    public class ValuePair<TKey, TValue>
    {
        public TValue Value { get; set; }
        public TKey Key { get; set; }
        public ValuePair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}
