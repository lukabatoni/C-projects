using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class Node<T> where T : IComparable<T>
    {
        public T Value;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class Bst<T> where T : IComparable<T>
    {
        private Node<T> root;

        public Bst() 
        {
            root = null;
        }

        public void Insert(T el)
        {
            root = InsertRec(root, el);
        }

        private Node<T> InsertRec(Node<T> current, T el)
        {
            if (current == null)
            {
                return new Node<T>(el);
            }

            if (el.CompareTo(current.Value) < 0)
            {
                current.Left = InsertRec(current.Left, el);
            }
            else if (el.CompareTo(current.Value) > 0)
            {
                current.Right = InsertRec(current.Right, el);
            }

            return current;
        }

        public bool Search(T el)
        {
            return SearchRec(root, el);
        }

        private bool SearchRec(Node<T> current, T el)
        {
            if (current == null)
            {
                return false;
            }

            if ((current.Value).CompareTo(el) == 0)
            {
                return true;
            }
            else if (el.CompareTo(current.Value) < 0)
            {
                return SearchRec(current.Left, el);
            }
            else { return SearchRec(current.Right, el); }
        }
    }
}
