using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class MyStack<T>
    {
        private T[] arr;
        private int size;
        private int count;

        public MyStack()
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

        public void Push(T item)
        {
            if (count == size)
            {
                IncreaseArr();
            }

            arr[count] = item;
            count++;
        }

        public T Pop()
        {
            if(count == 0)
            {
                Console.WriteLine("Stack is empty!");
            }

            T[] newArr = new T[size];
            for (int i = 0; i < count - 1; i++)
            {
                newArr[i] = arr[i];
            }
            T pop = arr[count - 1];
            arr = newArr;
            count--;
            return pop;
        }

        public T Peek()
        {
            return arr[count - 1];
        }
    }
}
