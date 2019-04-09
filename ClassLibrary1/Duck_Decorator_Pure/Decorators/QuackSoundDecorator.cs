using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator.Interfaces;
using Duck_Decorator_Pure.Decorators;

namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class QuackSoundDecorator : DuckDecorator
    {
        public QuackSoundDecorator(IDuck duck) : base(duck)
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
