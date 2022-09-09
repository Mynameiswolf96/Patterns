using UnityEngine;

namespace Observer.Scripts
{
    public class Dancer
    {
        public void Listen(Radio radio)
        {
            radio.OnNextSong += OnNextSong;
        }

        private void OnNextSong(string songName)
        {
            StartDancing();
        }

        private void StartDancing()
        {
            Debug.Log("Dancer.StartDancing: ");
        }
    }
}