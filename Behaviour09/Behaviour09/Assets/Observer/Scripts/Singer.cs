using UnityEngine;

namespace Observer.Scripts
{
    public class Singer
    {
        public void Listen(Radio radio)
        {
            radio.OnNextSong += OnNextSong;
        }

        private void OnNextSong(string songName)
        {
            StartSinging(songName);
        }

        private void StartSinging(string songName)
        {
            Debug.Log($"Singer.StartSinging: {songName}");
        }
    }
}