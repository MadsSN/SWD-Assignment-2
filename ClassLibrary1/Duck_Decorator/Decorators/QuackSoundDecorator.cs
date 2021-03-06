﻿using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator.Decorators;
using Duck_Decorator.Interfaces;

namespace Duck_Decorator.QuackBehaviours
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
