using System;

namespace algs_lessons.Priority_queue
{
    public class MinPQ<T> where T: IComparable
    {
        private T[] pq;
        private int N = 0;

        public MinPQ(int N)
        {
            pq = new T[N + 1];
        }
        
        public bool IsEmpty() {
            return N == 0;
        }

        public int Size() {
            return N;
        }

        public void Insert(T v) {
            pq[++N] = v;
            Swim(N);
        }

        public T Min() {
            if (IsEmpty()) throw new InvalidOperationException("Priority queue underflow");
            return pq[1];
        }

        public T DelMin() {
            if (IsEmpty()) throw new InvalidOperationException("Priority queue underflow");

            T min = pq[1];
            Exch(1, N--);
            Sink(1);
            pq[N+1] = default;
            return min;
        }

        private bool Greater(int i, int j) {
            return pq[i].CompareTo(pq[j]) > 0;
        }

        private void Exch(int i, int j) {
            T t = pq[i];
            pq[i] = pq[j];
            pq[j] = t;
        }

        private void Swim(int k) {
            while (k > 1 && Greater(k/2, k)) {
                Exch(k/2, k);
                k = k / 2;
            }
        }

        private void Sink(int k) {
            while (2 * k <= N) {
                int j = 2 * k;
                if (j < N && Greater(j, j + 1)) j++;
                if (!Greater(k,j)) break;
                Exch(k,j);
                k = j;
            }
        }
    }
}