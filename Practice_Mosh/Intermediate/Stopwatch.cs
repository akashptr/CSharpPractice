using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Intermediate
{
    internal class Stopwatch
    {
        private bool _isRunning;
        private DateTime _start;
        private DateTime _end;
        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running");
            _start = DateTime.Now;
            _isRunning = true;
            Console.WriteLine("Stopwatch started");
        }
        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running");
            _end = DateTime.Now;
            _isRunning= false;
            Console.WriteLine("Stopwatch stopped");
        }
        public TimeSpan Duration()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is still running");
            return _end - _start;
        }
    }
}
