using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Advance.Generics
{
    public class Nullable<T> where T : struct
    {
        private object? _value;
        public Nullable()
        {
            _value = null;
        }
        public Nullable(T value)
        {
            _value = value;
        }
        public bool IsNull
        {
            get { return _value != null; }
        }
        public T GetValueOrDefault()
        {
            if (IsNull)
                return default;
            return (T)_value;
        }
    }
}
