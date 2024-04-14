namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test Swap
            //int[] arr = { -1, 2, 3 , -4, -5};
            //Swap<int>(2,1,arr);

            //test Max
            //Console.WriteLine(FindMax<int>(arr));


            //TEST QUEUE
            //MyQueue<int> queue = new MyQueue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());

            //queue.Enqueue(17);
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Dequeue());


            //TEST STACK
            //MyStack<int> stack = new MyStack<int>();
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //stack.Push(5);
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //TEST BST
            //Bst<int> bst = new Bst<int>();
            //bst.Insert(10);
            //bst.Insert(5);
            //bst.Insert(15);
            //bst.Insert(8);
            //bst.Insert(3);

          
            //Console.WriteLine(bst.Search(10));
            //Console.WriteLine(bst.Search(8));
            //Console.WriteLine(bst.Search(15));
            //Console.WriteLine(bst.Search(4));


        }

        //TASK1
        public static void Swap<T>(T el1, T el2, T[] arr)
        {
            if (arr == null || !arr.Contains(el1) || !arr.Contains(el2))
            {
                Console.WriteLine("Invalid arguments!!!");
            }
            else
            {
                int index1 = Array.IndexOf(arr, el1);
                int index2 = Array.IndexOf(arr, el2);

                arr[index1] = el2;
                arr[index2] = el1;
            }
        }

        //TASK2

        public static T FindMax<T>(T[] arr) where T : IComparable
        {
            if (arr.Length == 0 || arr == null)
            {
                Console.WriteLine("Invalid arguments!!!");
            }

            T max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                {
                    max = arr[i];
                }
            }
            return max;
        }

       
    }
}
