using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator_Pure.Interfaces;
using Duck_Decorator_Pure.Decorators;
namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class DuckFishDecorator : DuckDecorator
    {
        public DuckFishDecorator(IDuck duck) : base(duck)
        {

        }

        public override void Eat()
        {
            base.Move();
            Fish();
        }

        private void Fish()
        {
            Console.WriteLine("Fish");
        }
    }
}
