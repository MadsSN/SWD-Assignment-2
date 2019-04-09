using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator_Pure.Interfaces;
using Duck_Decorator_Pure.Decorators;

namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class DuckQuackDecorator : DuckDecorator
    {
        public DuckQuackDecorator(IDuck duck) : base(duck)
        {

        }

        public override void MakeSound()
        {
            base.MakeSound();
            Quack();
        }

        private void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
