using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator_Pure.Decorators;
using Duck_Decorator_Pure.Interfaces;

namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class SqueakDuckDecorator : DuckDecorator
    {
        public SqueakDuckDecorator(IDuck duck) : base(duck)
        {

        }

        public override void Sound()
        {
            base.Sound();
            Squeak();
        }

        private void Squeak()
        {
            Console.WriteLine("Squeak");
        }
    }
}
