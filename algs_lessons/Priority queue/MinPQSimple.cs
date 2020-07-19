using System;

namespace algs_lessons.Priority_queue
{
    public class MinPQSimple<T> where T : IComparable
    {
        private int N = 0;
        private readonly T[] items;

        public MinPQSimple(int N)
        {
            items = new T[N];
        }

        public bool Empty()
        {
            return N == 0;
        }

        public void Insert(T item)
        {
            items[N++] = item;
        }

        public T DelMin()
        {
            int min = 0;
            for (int j = 1; j < N; j++)
            {
                if (items[min].CompareTo(items[j]) > 0)
                {
                    min = j;
                }
            }
            Exch(min, N - 1);
            return items[--N];
        }
        
        private void Exch(int i, int j) {
            T t = items[i];
            items[i] = items[j];
            items[j] = t;
        }
    }
}