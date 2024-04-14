using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class MyList<T> : IEnumerable<T>
    {
        private T[] array;
        private int count;

        public MyList()
        {
            array = new T[4]; 
            count = 0;
        }

        public void Add(T item)
        {
            if (count == array.Length)
            {
                Array.Resize(ref array, array.Length * 2);
            }
            array[count] = item;
            count++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new MyListException("clocetion is null");
            }

            foreach (var item in collection)
            {
                Add(item);
            }
        }


        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public void RemoveRange(int start, int count) 
        {
            for(int i = 0; i < count; i++)
            {
                this.RemoveAt(start);   
            }
        }

        public bool Contains(T item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                return true;
            }
            return false;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if ((array[i] == null && item == null) || (array[i] != null && array[i].Equals(item)))
                {
                    return i;
                }
            }
            return -1;
        }


        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new MyListException("index is out of range");
            }

            for (int i = index; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            count--;
        }

        public T this[int index]
        {

            get
            {
                if (index < 0 || index >= count)
                {
                    throw new MyListException("index is out of range");
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new MyListException("index is out of range");
                }
                array[index] = value;
            }
        }

        public int Count
        {
            get { return count; }
        }

        public IEnumerator<T> GetEnumerator()
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
