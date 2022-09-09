using System;

namespace Observer.Scripts
{
    public class Radio : IRadio
    {
        public event Action<string> OnNextSong;

        private int _songDuration = 4;

        private int _currentTime;
        private int _nextSongTime;

        public void Wait(int numMinutes)
        {
            _currentTime += numMinutes;

            if (_currentTime >= _nextSongTime)
            {
                OnNextSong?.Invoke("The next best song ever");

                _nextSongTime = _currentTime + _songDuration;
            }
        }
    }
}