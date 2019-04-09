using System;
using Duck_Strategy.QuackBehaviours;
using Duck_Strategy.Interfaces;
namespace Duck_Strategy
{
    public class Duck
    {
        public ISoundBehaviour SoundBehaviour {private get; set; }

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
