using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator_Pure.Interfaces;
using Duck_Decorator_Pure.Decorators;
namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class DuckJumpDecorator : DuckDecorator
    {
        public DuckJumpDecorator(IDuck duck) : base(duck)
        {

        }

        public override void Move()
        {
            base.Move();
            Jump();
        }

        private void Jump()
        {
            Console.WriteLine("Jump");
        }
    }
}
