using algs_lessons.Priority_queue;
using Xunit;

namespace algs_lessons.Tests
{
    public class MinPQTest
    {
        [Fact]
        public void PQTest() {
            var tested = new MinPQ<int>(30);;
            // tested.insert(30);
            // var min = tested.delMin();
            tested.Insert(10);
            tested.Insert(20);
            tested.Insert(30);
            tested.Insert(5);
            tested.Insert(1);
            Assert.Equal(1, tested.DelMin());
            Assert.Equal(5, tested.DelMin());
            Assert.Equal(10, tested.DelMin());
            Assert.Equal(20, tested.DelMin());
        }
        
        [Fact]
        public void PQSimpleTest() {
            var tested = new MinPQSimple<int>(30);;
            // tested.insert(30);
            // var min = tested.delMin();
            tested.Insert(10);
            tested.Insert(20);
            tested.Insert(30);
            tested.Insert(5);
            tested.Insert(1);
            Assert.Equal(1, tested.DelMin());
            Assert.Equal(5, tested.DelMin());
            Assert.Equal(10, tested.DelMin());
            Assert.Equal(20, tested.DelMin());
        }
    }
}