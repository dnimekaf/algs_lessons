using algs_lessons.Algorithms;
using Xunit;

namespace algs_lessons.Tests
{
    public class AlgorithmsTest
    {
        [Fact]
        public void EuclidGcdTest()
        {
            var euclid = new Euclid();
            Assert.Equal(6,euclid.gcd(24,18));
            Assert.Equal(15,euclid.gcd(45,15));
            Assert.Equal(6, euclid.gcd(42, 24));
        }

        [Fact]
        public void DijkstraEvaluateTest()
        {
            var exp1 = "( 1 + ( ( 2 + 3 ) * ( 4 * 5 ) ) )"; 
            var exp2 = "( ( 1 + sqrt ( 5,0 ) ) / 2,0 )";
            var tested = new DijkstraEvaluate();
            double result = tested.Evaluate(exp1);
            Assert.Equal(101.0, result);
            result = tested.Evaluate(exp2);
            Assert.Equal(1.618033988749895, result);
        }

        [Fact]
        public void BinarySearchTest()
        {
            var arr = new int[]{1,2,5,7,9,13,24,26,78,96,102,113};
            var bs = new BinarySearch();
            var res = bs.Rank(78, arr);
            Assert.Equal(8, res);
            
        }
        
        [Fact]
        public void BinarySearchRecTest()
        {
            var arr = new int[]{1,2,5,7,9,13,24,26,78,96,102,113};
            var bs = new BinarySearch();
            var res = bs.RankRec(78, arr);
            Assert.Equal(8, res);
        }
    }
}