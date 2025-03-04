using System.Timers;
using Timer = System.Timers.Timer;

namespace TelephonyUI.Services
{
    public class CallService : IDisposable
    {
        public bool IsCallActive { get; private set; }
        public string CurrentNumber { get; private set; }
        public TimeSpan CallDuration { get; private set; }
        public event Action OnCallStateChanged;

        private Timer _timer;
        private DateTime _callStartTime;

        public void StartCall(string number)
        {
            CurrentNumber = number;
            IsCallActive = true;
            _callStartTime = DateTime.Now;

            _timer?.Dispose();
            _timer = new Timer(1000);
            _timer.Elapsed += (s, e) =>
            {
                CallDuration = DateTime.Now - _callStartTime;
                NotifyStateChanged();
            };
            _timer.Start();

            NotifyStateChanged();
        }

        public void EndCall()
        {
            IsCallActive = false;
            _timer?.Stop();
            _timer?.Dispose();
            CallDuration = TimeSpan.Zero;
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
        {
            OnCallStateChanged?.Invoke();
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

    }
}
