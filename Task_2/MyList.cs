using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {

        private T[] list;

        private int position;

        public int Count { get { return list.Length; } }

        public T this[int index]
        {
            get { return list[index]; }
        }

        public MyList()
        {
            list = new T[0];
            position = -1;
        }

        public void Add(T item)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length -1] = item;
        }


        public void Reset() => position = -1;


        public T Current {  get { return list[position]; } }

        object System.Collections.IEnumerator.Current { get { return Current; } }

        public bool MoveNext()
        {
            if (position < list.Length -1)
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

        void IDisposable.Dispose()
        {
            Reset();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
