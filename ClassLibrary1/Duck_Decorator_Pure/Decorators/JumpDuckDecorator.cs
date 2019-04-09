using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator_Pure.Interfaces;
using Duck_Decorator_Pure.Decorators;
namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class JumpDuckDecorator : DuckDecorator
    {
        public JumpDuckDecorator(IDuck duck) : base(duck)
        {

        }

        public override void Movement()
        {
            base.Movement();
            Jump();
        }

        private void Jump()
        {
            Console.WriteLine("Jump");
        }
    }
}
