namespace algs_lessons.Algorithms
{
    public class BinarySearch
    {
        public int Rank(int key, int[] a) {
            int lo = 0;
            int hi = a.Length - 1;
            while (lo <= hi) {
                int mid = lo + (hi - lo) / 2;
                if (key < a[mid]) hi = mid - 1;
                else if (key > a[mid]) lo = mid + 1;
                else return mid;
            }
            return -1;
        }

        public int RankRec(int key, int[] a)
        {
            return RankRecImpl(key, a, 0, a.Length - 1);
        }

        private int RankRecImpl(int key, int[] a, int lo, int hi)
        {
            if (lo > hi) return -1;
            
            int mid = lo + (hi - lo) / 2;
            if (key < a[mid]) return RankRecImpl(key, a, lo, mid - 1);
            if (key > a[mid]) return RankRecImpl(key, a, mid + 1, hi);
            return mid;
        }
    }
}