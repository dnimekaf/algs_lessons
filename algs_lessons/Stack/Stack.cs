using System;
using System.Collections.Generic;
using System.Collections;

namespace algs.DataStructures.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private Node first;
        private int N;

        private class Node {
            public readonly T Element;
            public readonly Node next;

            public Node(T item, Node next) {
                Element = item;
                this.next = next;
            }
        }

        public bool IsEmpty() {
            return first == null;
        }

        public int Size() {
            return N;
        }

        public void Push(T item) {
            Node oldFirst = first;
            first = new Node(item, oldFirst);
            N++;
        }

        public T Pop() {
            if (first != null)
            {
                T item = first.Element;
                first = first.next;
                N--;
                return item;
            }

            throw new ArgumentException();
        }

        public T peek() {
            if (first != null)
            {
                return first.Element;
            }
            return default;
        }


        #region Iteration

        private class StackEnumerator : IEnumerator<T>
        {
            private Node root;
            private readonly Node first;
            public StackEnumerator(Node root)
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
            return new StackEnumerator(first);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}