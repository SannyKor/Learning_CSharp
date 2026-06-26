using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task_4_OrderedDictionry_
{
    public class MyOrderedDictionary<TKey, TValue> : IEquatable<MyOrderedDictionary<TKey, TValue>>, ICollection<KeyValuePair<TKey, TValue>> where TKey : notnull
    {
        private Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();
        private List <TKey> _order = new List<TKey>();

        public int Count => _dictionary.Count;

        public bool IsReadOnly => false;
        public TValue this[TKey key]
        {
            get => _dictionary[key];
            set
            {
                if(!_dictionary.ContainsKey(key))
                {
                    _order.Add(key);
                }
                _dictionary[key] = value;
            }
        }
        public TValue GetAtIndex(int index)
        {
            if ((index >= _order.Count)||index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return _dictionary[_order[index]];
        }
        public void Add(KeyValuePair<TKey, TValue> item)
        {
            Add(item.Key, item.Value);
        }
        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);
            _order.Add(key);
        }

        public void Clear()
        {
            _dictionary.Clear();
            _order.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return _dictionary.TryGetValue(item.Key, out TValue value) && EqualityComparer<TValue>.Default.Equals(value, item.Value);
        }
        public bool ContainsKey(TKey key)
        {
            return _dictionary.ContainsKey(key);
        }
        public bool ContainsValue(TValue value)
        {
            return _dictionary.ContainsValue(value);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach(var key in _order)
            {
                yield return new KeyValuePair<TKey, TValue>(key, _dictionary[key]);
            }
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }
        public bool Remove(TKey key)
        {
            if(key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            bool removed = _dictionary.Remove(key);
            if(removed)
            {
                _order.Remove(key);
            }
            return removed;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Equals(MyOrderedDictionary<TKey, TValue>? other)
        {
            if (ReferenceEquals(this, other))
            {
                Console.WriteLine("Колекції рівні за посиланням");
                return true;
            }
            if (other == null)
            {
                Console.WriteLine("Колекції не рівні, оскільки інша колекція є null");
                return false;
            }
            if(Count != other.Count)
            {
                Console.WriteLine("Колекції не рівні, оскільки вони мають різну кількість елементів");
                return false;
            }
            var enum1 = this.GetEnumerator();
            var enum2 = other.GetEnumerator();
            while(enum1.MoveNext() && enum2.MoveNext())
            {
                var item1 = enum1.Current;
                var item2 = enum2.Current;
                if (!item1.Equals(item2))
                {
                    Console.WriteLine("Колекції не рівні, оскільки вони мають різні елементи");
                    return false;
                }
            }
            Console.WriteLine("Колекції рівні");
            return true;
        }
    }
}
