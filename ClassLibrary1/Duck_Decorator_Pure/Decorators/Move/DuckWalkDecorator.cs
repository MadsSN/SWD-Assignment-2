using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator_Pure.Interfaces;
using Duck_Decorator_Pure.Decorators;
namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class DuckWalkDecorator : DuckDecorator
    {
        public DuckWalkDecorator(IDuck duck) : base(duck)
        {

        }

        public override void Move()
        {
            base.Move();
            Walk();
        }

        private void Walk()
        {
            Console.WriteLine("Walk");
        }
    }
}