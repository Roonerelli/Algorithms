using System.Collections.Generic;

namespace Algorithms.puzzles
{
    /// <summary>
    /// https://www.interviewcake.com/question/queue-two-stacks
    /// Implement a queue with 2 stacks. 
    /// Your queue should have an enqueue and a dequeue function and it should be "first in first out" (FIFO).
    /// Optimize for the time cost of m function calls on your queue. These can be any mix of enqueue and dequeue calls.
    /// Assume you already have a stack implementation and it gives O(1) time push and pop.
    /// </summary>
    public class QueueWithTwoStacks<T>
    {
        private readonly Stack<T> _inStack1 = new Stack<T>(); 
        private readonly Stack<T> _outStack2 = new Stack<T>(); 

        public void Enqueue(T item)
        {
            _inStack1.Push(item);
        }

        public T Dequeue()
        {
            if (_outStack2.Count == 0)
            {
                while (_inStack1.Count > 0)
                {
                    _outStack2.Push(_inStack1.Pop());
                }

                return _outStack2.Pop();
            }
            
            return _outStack2.Pop();
        }
    }
}
