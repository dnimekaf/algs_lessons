using System.Collections;
using System.Collections.Generic;

namespace algs_lessons.DataStructures.Queue
{
    public class Queue<T> : IEnumerable<T>
    {
        private Node root;
        private Node last;
        private int _size = 0;
        
        private class Node
        {
            public Node(T element)
            {
                Element = element;
            }
            
            public readonly T Element;
            public Node next;
        }


        public void Enqueue(T element)
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

        public T Dequeue()
        {
            var result = root;
            if (result != null)
            {
                root = result.next;
                _size--;
                return result.Element;
            }

            return default;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public int Size()
        {
            return _size;
        }

        public Queue<T> Reverse()
        {
            var queue = new Queue<T>();
            var current = root;
            while (current != null)
            {
                var node = new Node(current.Element) {next = queue.root};
                queue.root = node;
                current = current.next;
            }
            return queue;
        }


        #region Iteration

        private class QueueEnumerator : IEnumerator<T>
        {
            private Node root;
            private readonly Node first;
            public QueueEnumerator(Node root)
            {
                this.root = root;
                first = root;
            }
            
            public bool MoveNext()
            {
                if (root.next != null)
                {
                    root = root.next;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                root = first;
            }

            public T Current => root.Element;

            object? IEnumerator.Current => Current;

            public void Dispose()
            {
                root = null;
            }
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return new QueueEnumerator(root);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}