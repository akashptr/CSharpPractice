using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Advance.Generics
{
    public class GenericStack<T> where T : class, new()
    {
        private List<T> _data;
        public GenericStack()
        {
            _data = new List<T>();
        }
        public void Push(T item)
        {
            _data.Add(item);
        }
        public T Pop()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Stack underflow");
            int lastIndex = _data.Count - 1;
            T lastItem = _data[lastIndex];
            _data.RemoveAt(lastIndex);
            return lastItem;
        }
        public T Peek()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Stack empty");
            return _data[_data.Count - 1];
        }
    }
}
