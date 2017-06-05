using System;
using System.Collections;
using System.Collections.Generic;

namespace BeagleAPI.Misc
{
    public abstract class DictionaryEx<TKey, TValue> : IDictionary<TKey, TValue>
    {
        KeyCollection keyCollection;
        ValueCollection values;

        protected abstract void SetValue(TKey key, TValue value);
        public abstract void Add(TKey key, TValue value);
        public abstract bool ContainsKey(TKey key);
        public abstract bool Remove(TKey key);
        public abstract bool TryGetValue(TKey key, out TValue value);

        protected DictionaryEx() { }

        public TValue this[TKey key]
        {
            get
            {
                TValue value;
                if (!TryGetValue(key, out value))
                    throw new KeyNotFoundException();

                return value;
            }
            set
            {
                SetValue(key, value);
            }
        }

        public int Count
        {
            get;
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public ICollection<TKey> Keys
        {
            get
            {
                if (keyCollection == null)
                    this.keyCollection = new KeyCollection(this);

                return keyCollection;
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                if (values == null)
                    this.values = new ValueCollection(this);

                return values;
            }
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            this.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            TValue value;
            if (!this.TryGetValue(item.Key, out value))
                return false;

            return EqualityComparer<TValue>.Default.Equals(value, item.Value);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            Copy(this, array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            if (!Contains(item))
                return false;

            return Remove(item.Key);
        }
        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        abstract class Collection<T> : ICollection<T>
        {
            protected readonly IDictionary<TKey, TValue> dictionary;

            protected Collection(IDictionary<TKey, TValue> dic)
            {
                dictionary = dic;
            }

            public int Count
            {
                get
                {
                    return dictionary.Count;
                }
            }

            public bool IsReadOnly
            {
                get
                {
                    return true;
                }
            }

            public void Add(T item)
            {
                
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                Copy(this, array, arrayIndex);
            }

            public virtual bool Contains(T item)
            {
                foreach (T element in this)
                    if (EqualityComparer<T>.Default.Equals(element, item))
                        return true;

                return false;
            }

            public IEnumerator<T> GetEnumerator()
            {
                foreach (KeyValuePair<TKey, TValue> pair in dictionary)
                {
                    yield return GetItem(pair);
                }
            }

            protected abstract T GetItem(KeyValuePair<TKey, TValue> pair);

            public bool Remove(T item)
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        private class KeyCollection : Collection<TKey>
        {
            public KeyCollection(IDictionary<TKey, TValue> dic) : base(dic)
            {

            }

            protected override TKey GetItem(KeyValuePair<TKey, TValue> pair)
            {
                return pair.Key;
            }

            public override bool Contains(TKey item)
            {
                return dictionary.ContainsKey(item);
            }

        }

        private class ValueCollection : Collection<TValue>
        {
            public ValueCollection(IDictionary<TKey, TValue> dic) : base(dic) { }

            protected override TValue GetItem(KeyValuePair<TKey, TValue> pair)
            {
                return pair.Value;
            }
        }

        public static void Copy<T>(ICollection<T> source, T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("Array is null");

            if (arrayIndex < 0 || arrayIndex > array.Length)
                throw new ArgumentOutOfRangeException("ArrayIndex");

            if ((array.Length - arrayIndex) < source.Count)
                throw new ArgumentException("Destination array is not large enough. Check array length and arrayIndex");

            foreach (T item in source)
                array[arrayIndex++] = item;
        }
    }

    public class DictionaryExtended<TKey, TVal> : DictionaryEx<TKey, TVal>
    {
        public override void Add(TKey key, TVal value)
        {
        }

        public override bool ContainsKey(TKey key)
        {
            return false;
        }

        public override bool Remove(TKey key)
        {
            return false;
        }

        public override bool TryGetValue(TKey key, out TVal value)
        {
            throw new NotImplementedException();
        }

        protected override void SetValue(TKey key, TVal value)
        {
            throw new NotImplementedException();
        }
    }
}
