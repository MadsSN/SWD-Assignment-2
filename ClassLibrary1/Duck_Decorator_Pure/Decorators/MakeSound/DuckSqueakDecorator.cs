using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator_Pure.Decorators;
using Duck_Decorator_Pure.Interfaces;

namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class DuckSqueakDecorator : DuckDecorator
    {
        public DuckSqueakDecorator(IDuck duck) : base(duck)
        {

        }

        public override void MakeSound()
        {
            base.MakeSound();
            Squeak();
        }

        private void Squeak()
        {
            Console.WriteLine("Squeak");
        }
    }
}
