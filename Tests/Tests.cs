using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using StackRealisation;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private Stack<int> _numbers = new Stack<int>();

        private Stackkk _ints = new Stackkk();

        [Test]
        public void PeekFunctionTest()
        {
            _numbers.Push(1);
            _numbers.Push(8);
            _numbers.Push(5);
            
            _ints.Push(1);
            _ints.Push(8);
            _ints.Push(5);
            
            int peekInStack = _numbers.Peek();
            int peekInStackkk = _ints.Peek();
            Assert.True(peekInStack == peekInStackkk);
        }
        
        [Test]
        public void PopFunctionTest()
        {
            _numbers.Push(1);
            _numbers.Push(8);
            _numbers.Push(5);
            
            _ints.Push(1);
            _ints.Push(8);
            _ints.Push(5);
            
            int peekInStack = _numbers.Pop();
            int peekInStackkk = _ints.Pop();
            
            Assert.True(peekInStack == peekInStackkk);
        }

        [Test]
        public void IsEmptyFunctionTest()
        {
            _numbers.Push(1);
            
            _ints.Push(1);
            
            _numbers.Pop();
            _ints.Pop();
            
            bool bothStacksEmpty = _ints.IsEmpty() && _numbers.Count == 0;
            Assert.True(bothStacksEmpty);
        }
    }
}