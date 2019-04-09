using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator_Pure.Interfaces;
using Duck_Decorator_Pure.Decorators;
namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class DuckGrassDecorator : DuckDecorator
    {
        public DuckGrassDecorator(IDuck duck) : base(duck)
        {

        }

        public override void Eat()
        {
            base.Move();
            Grass();
        }

        private void Grass()
        {
            Console.WriteLine("Grass");
        }
    }
}
