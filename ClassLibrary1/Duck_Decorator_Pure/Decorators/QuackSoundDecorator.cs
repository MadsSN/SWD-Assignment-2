using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator_Pure.Decorators;
using Duck_Decorator_Pure.Interfaces;

namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class QuackSoundDecorator : SoundBehaviourDecorator
    {
        public QuackSoundDecorator(ISoundBehaviour soundBehaviour) : base(soundBehaviour)
        {

        }

        public override void Sound()
        {
            base.Sound();
            Quack();
        }

        private void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
