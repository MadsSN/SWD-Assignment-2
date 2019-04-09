using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator_Pure.Decorators;
using Duck_Decorator_Pure.Interfaces;

namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class HonkSoundDecorator : SoundBehaviourDecorator
    {
        public HonkSoundDecorator(ISoundBehaviour soundBehaviour) : base(soundBehaviour)
        {
            
        }

        public override void Sound()
        {
            base.Sound();
            Honk();
        }

        private void Honk()
        {
            Console.WriteLine("Honk");
        }
    }
}
