using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public interface IStack
    {
        void Push(string item);
        string Pop();
        bool IsEmpty();
    }

    public class Stack : IStack
    {
        private Node _first = null;

        private class Node
        {
            public string Item { get; set; }
            public Node Next { get; set; }
        }

        public void Push(string item)
        {
            var oldFirst = _first;
            _first = new Node
            {
                Item = item, 
                Next = oldFirst
            };
        }

        public string Pop()
        {
            string item = _first.Item;
            _first = _first.Next;
            return item;
        }

        public bool IsEmpty()
        {
            return _first == null;
        }
    }
}