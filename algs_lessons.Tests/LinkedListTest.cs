using System;
using algs_lessons.LinkedList;
using Xunit;
using Xunit.Abstractions;

namespace algs_lessons.Tests
{
    public class LinkedListTest
    {
        
        private readonly ITestOutputHelper _outputHelper;

        public LinkedListTest(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        private void FillList(LinkedList<string> list)
        {
            list.Add("She");
            list.Add("sells");
            list.Add("sea");
            list.Add("shells");
            list.Add("by");
            list.Add("the");
            list.Add("sea");
            list.Add("shore");
        }
        
        [Fact]
        public void LinkedListAddTest()
        {
            var list = new LinkedList<string>();
            Assert.Equal(null, list.Get(5));
            
            FillList(list);
            Assert.Equal("She", list.Get(0));
            Assert.Equal("shore", list.Get(7));
        }
        
        [Fact]
        public void LinkedListIterationTest()
        {
            var list = new LinkedList<string>();
            foreach (var item in list)
            {
                _outputHelper.WriteLine(item);
            }
            Assert.Equal(null, list.Get(5));
            
            FillList(list);

            foreach (var item in list)
            {
                _outputHelper.WriteLine(item);
            }
        }
        
        [Fact]
        public void LinkedListReverseTest()
        {
            var list = new LinkedList<string>();
            FillList(list);
            list = list.Reverse();

            foreach (var item in list)
            {
                _outputHelper.WriteLine(item);
            }
        }
    }
}