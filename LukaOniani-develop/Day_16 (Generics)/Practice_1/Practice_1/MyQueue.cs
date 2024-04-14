using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class MyQueue<T>
    {
        private T[] arr;
        private int size;
        private int count;

        public MyQueue() 
        {
            size = 5;
            arr = new T[size];
            count = 0;
        }

        private void IncreaseArr()
        {
            size *= 2;
            T[] newArr = new T[size];
            for (int i = 0; i < count; i++) 
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }

        public void Enqueue(T item)
        {
            if (count == size) 
            {
                IncreaseArr();
            }

            arr[count] = item;
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is empty!");
            }

            T[] newArr = new T[size];
            T first = arr[0];
            for (int i = 1; i < count; i++)
            {
                newArr[i-1] = arr[i];
            }
            arr = newArr;
            count--;
            return first;
        }

        public T Peek() {  return arr[0]; }
    }
}
