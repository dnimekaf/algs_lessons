using System;
using algs_lessons.DataStructures.Queue;
using Xunit;

namespace algs_lessons.Tests
{
    public class QueueTest
    {
        [Fact]
        public void QueueAddTest()
        {
            var queue = new Queue<string>();
            Assert.Equal(null, queue.Dequeue());
            
            queue.Enqueue("She");
            queue.Enqueue("sells");
            queue.Enqueue("sea");
            queue.Enqueue("shells");
            queue.Enqueue("by");
            queue.Enqueue("the");
            queue.Enqueue("sea");
            queue.Enqueue("shore");
            
            
            Assert.Equal("She", queue.Dequeue());
            Assert.Equal("sells", queue.Dequeue());
            Assert.Equal("sea", queue.Dequeue());
            Assert.Equal("shells", queue.Dequeue());
            Assert.Equal("by", queue.Dequeue());
            Assert.Equal("the", queue.Dequeue());
            Assert.Equal("sea", queue.Dequeue());
            Assert.Equal("shore", queue.Dequeue());
            Assert.Equal(null, queue.Dequeue());
            
        }
    }
}