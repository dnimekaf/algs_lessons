namespace algs_lessons.Algorithms
{
    public class Euclid
    {
        /// <summary>
        /// Поиск наибольшего общего делителя
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public int gcd(int p, int q) {
            if (q == 0) {
                return p;
            }
            int r = p % q;
            return gcd(q,r);
        }
    }
}    