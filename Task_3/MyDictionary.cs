using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class MyDictionary<T,R> : IEnumerable, IEnumerator<Element<T, R>>
    {
        //цього разу вирішив зробити так щоб максимально приблизити до Dictionary
        Element<T, R>[] elements;

        int position;

        public int Count { get { return elements.Length; } }
        public R this[T index]
        {
            get
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    if (elements[i].Key.Equals(index))
                    {
                        return elements[i].Value;
                    }
                }

                throw new ArgumentException("Немае такого ключа!");
            }
        }

        public MyDictionary()
        {
            elements = new Element<T, R>[0];
            position = -1;
        }
        public void Add(T key, R value)
        {
            Array.Resize(ref elements, elements.Length +1);
            elements[elements.Length - 1].Key = key;
            elements[elements.Length - 1].Value = value;
        }
        public bool ContainsKey(T key)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Key.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }

        public Element<T,R> Current => elements[position];

        object System.Collections.IEnumerator.Current { get { return Current; } }

        public void Reset() => position = -1;

        void IDisposable.Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            if (position < elements.Length -1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public IEnumerator<Element<T, R>> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
