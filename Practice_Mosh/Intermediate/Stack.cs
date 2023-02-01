using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Intermediate
{
    internal class Stack
    {
        private List<Object> _data;
        public Stack()
        {
            _data = new List<Object>();
        }
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Stack cannot store null reference");
            _data.Add(obj);
        }
        public object Pop()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Stack underflow");
            var lastIndex = _data.Count - 1;
            var lastElement = _data[lastIndex];
            _data.RemoveAt(lastIndex);
            return lastElement;
        }
        public void Clear()
        {
            _data.Clear();
        }
    }
}
