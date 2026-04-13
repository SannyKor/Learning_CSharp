using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace Task_3
{
    internal class StopwatchModel
    {
        private DispatcherTimer _timer;
        private TimeSpan _timeElapsed;
        public event Action<TimeSpan>? OnTimeChanged;

        public StopwatchModel()
        {
            _timeElapsed = TimeSpan.Zero;
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(10);
            _timer.Tick += (s, e) =>
            {
                _timeElapsed = _timeElapsed.Add(_timer.Interval);
                OnTimeChanged?.Invoke(_timeElapsed);
            };
        }

        public void Start() => _timer.Start();
        public void Stop() => _timer.Stop();
        public void Reset()
        {
            _timer.Stop();
            _timeElapsed = TimeSpan.Zero;
            OnTimeChanged?.Invoke(_timeElapsed);
        }
    }
}
