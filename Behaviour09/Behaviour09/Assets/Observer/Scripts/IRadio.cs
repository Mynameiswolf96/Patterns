using System;

namespace Observer.Scripts
{
    public interface IRadio
    {
        event Action<string> OnNextSong;
    }
}