using System.Collections;
using System.Collections.Generic;

namespace algs_lessons.LinkedList 
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node root;
        private Node last;
        private int _size;
        
        private class Node
        {
            public readonly T Element;
            public Node next;

            public Node(T element)
            {
                Element = element;
            }
        }

        public void Add(T element)
        {
            var newEl = new Node(element);
            if (last != null)
            {
                last.next = newEl;
            }
            
            if (root == null)
            {
                root = newEl;
            }
            last = newEl;
            _size++;
        }

        public T Get(int index)
        {
            int cnt = 0;
            var current = root;
            while (cnt < index && current != null)
            {
                cnt++;
                current = current.next;
            }

            if (current != null)
            {
                return current.Element;
            }
            return default;
        }

        public LinkedList<T> Reverse()
        {
            var list = new LinkedList<T>();
            var current = root;
            while (current != null)
            {
                var node = new Node(current.Element) {next = list.root};
                list.root = node;
                current = current.next;
            }
            return list;
        }
        
        public bool IsEmpty()
        {
            return _size == 0;
        }

        public int Size()
        {
            return _size;
        }
        
        #region Iteration

        private class ListEnumerator : IEnumerator<T>
        {
            private Node current;
            private readonly Node first;
            private bool started = false;
            public ListEnumerator(Node root)
            {
                first = root;
            }
            
            public bool MoveNext()
            {
                if (started == false)
                {
                    started = true;
                    current = first;
                    if (current != null)
                    {
                        return true;
                    }
                    return false;
                }
                
                if (current.next != null)
                {
                    current = current.next;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                current = first;
            }

            public T Current => current.Element;

            object? IEnumerator.Current => Current;

            public void Dispose()
            {
                current = null;
            }
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return new ListEnumerator(root);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}