using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator.Interfaces;
using Duck_Decorator_Pure.Decorators;

namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class HonkSoundDecorator : DuckDecorator
    {
        public HonkSoundDecorator(IDuck duck) : base(duck)
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
