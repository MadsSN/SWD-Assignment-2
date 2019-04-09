using System;
using Duck_Decorator.QuackBehaviours;
using Duck_Decorator.Interfaces;

namespace Duck_Decorator
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
