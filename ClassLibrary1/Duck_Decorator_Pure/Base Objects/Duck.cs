using System;
using Duck_Decorator_Pure.QuackBehaviours;
using Duck_Decorator_Pure.Interfaces;

namespace Duck_Decorator_Pure
{
    public class Duck
    {
        public ISoundBehaviour SoundBehaviour { get; set; }

        public Duck(ISoundBehaviour soundBehaviour)
        {
            SoundBehaviour = soundBehaviour;
        }

        public void Quack()
        {
            SoundBehaviour.Sound();
        }
    }
}
