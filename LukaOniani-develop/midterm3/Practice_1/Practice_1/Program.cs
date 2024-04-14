namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            
            list.RemoveRange(0, 2);
            


            Console.WriteLine(list.FirstOrDefault(x => x == 8));
            

            Console.WriteLine(list.Remove(1)); //true
            for(int j = 0;  j < list.Count; j++)
            {
                Console.WriteLine(list.ElementAt(j));
            }



            //chemi klasi

            MyList<int> myList = new MyList<int>();

            //Add
            for(int i = 1; i <= 7; i++)
            {
                myList.Add(i);
            }


            Console.WriteLine();

            Console.WriteLine("After adding some elements in the list: we get: ");
            Print(myList);
      
            


            //removeAt
            myList.RemoveAt(2);
            Console.WriteLine();
            Console.WriteLine("After removeAt index 2 we get: ");
            Print(myList);

            Console.WriteLine();

            //remove
            Console.WriteLine("15 not found in the list: " + myList.Remove(15)); //false 
            Console.WriteLine("4 found and removed in the list: " + myList.Remove(4)); //true
            Print(myList);

            Console.WriteLine();

            Console.WriteLine("myList contains 6? " + myList.Contains(6)); //true
            Console.WriteLine("myList contains -16? " + myList.Contains(-16)); //false

            //List size
            Console.WriteLine();
            Console.WriteLine("MyList Count: " + myList.Count);

            Console.WriteLine();

            myList.RemoveRange(1, 2);

            Print(myList);
            Console.WriteLine("MyList Count: " + myList.Count);

            Console.WriteLine();

            Console.WriteLine("Test foreach");
            foreach (int i in  myList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.WriteLine("LINQ METHODS: ");
            Console.WriteLine("use first method: " + myList.First(x => x > 6));
            Console.WriteLine("use first or default method: " + myList.FirstOrDefault(x => x > 100));

            var filteredMylist = myList.Where(x => x % 2 == 1);
            foreach (int i in filteredMylist)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            myList.Add(7);

            Console.WriteLine("use distinct method: ");
            var distinctElementList = myList.Distinct();
            foreach (int i in distinctElementList)
            { 
                Console.WriteLine(i); 
            }



            //List AddRange
            Console.WriteLine();
            Console.WriteLine("I almost forgor AddRange method :");
            myList.AddRange(filteredMylist);
            Print(myList);
        }

        public static void Print<T>(MyList<T> MyList)
        {
            Console.Write("[");
            for (int i = 0; i < MyList.Count; i++)
            {
                Console.Write(MyList[i]);
                if (i < MyList.Count - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("]");
        }

    }
}
