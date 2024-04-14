using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public static class MyListExtension
    {
        public static T First<T>(this MyList<T> Mylist, Func<T, bool> predicate)
        {
            if (Mylist == null)
            {
                throw new MyListException("given list is null");
            }

            if (predicate == null)
            {
                throw new MyListException("predicate not provided");
            }

            foreach (T item in Mylist)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            throw new MyListException("No element satisfies the condition");
        }

        public static T FirstOrDefault<T>(this MyList<T> Mylist, Func<T, bool> predicate)
        {
            if (Mylist == null)
            {
                throw new MyListException("given list is null");
            }

            if (predicate == null)
            {
                throw new MyListException("predicate not provided");
            }

            foreach (T item in Mylist)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return default;
        }

        public static IEnumerable<T> Where<T>(this MyList<T> Mylist, Func<T, bool> predicate)
        {
            if (Mylist == null)
            {
                throw new MyListException("given list is null");
            }

            if (predicate == null)
            {
                throw new MyListException("predicate not provided");
            }

            List<T> filteredList = new List<T>();

            foreach (T item in Mylist)
            {
                if (predicate(item))
                {
                    filteredList.Add(item);
                }
            }

            return filteredList;
        }


        public static IEnumerable<T> Distinct<T>(this MyList<T> MyList)
        {
            if (MyList == null)
            {
                throw new MyListException("given list is null");
            }

            HashSet<T> uniqueElements = new HashSet<T>();
            for (int i = 0; i < MyList.Count; i++)
            {
                uniqueElements.Add(MyList[i]);
            }

            List<T> distinctList = new List<T>(uniqueElements);
            return distinctList;
        }



        //public static IEnumerable<T> OrderBy<T>(this MyList<T> Mylist, Func<T, bool> predicate)
        //{
        //    if (Mylist == null)
        //    {
        //        throw new MyListException("given list is null");
        //    }

        //    if (predicate == null)
        //    {
        //        throw new MyListException("predicate not provided");
        //    }

        //    List<T> orderedList = new List<T>();

        //    for (int i = 0; i < Mylist.Count; i++)
        //    {
        //        orderedList
        //    }

        //}
    }
}
