using System;
using UnityEngine;


namespace Asteroids.Abstrac_Factory
{
    
    internal sealed class InputFactory 
    {
        public IInput CreateInput(RuntimePlatform platform)
        {
            switch (platform)
            {
                case RuntimePlatform.WindowsPlayer :
                case RuntimePlatform.WindowsEditor:
                    return new PCInput();
                case RuntimePlatform.Android:
                case RuntimePlatform.PS4:
                    return new ConsoleInput();
                default:
                    throw new ArgumentOutOfRangeException(nameof(platform), platform, null);
            }
        }
    }
}
