using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator_Pure.Interfaces;
using Duck_Decorator_Pure.Decorators;
namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class StepDuckDecorator : DuckDecorator
    {
        public StepDuckDecorator(IDuck duck) : base(duck)
        {

        }

        public override void Movement()
        {
            base.Movement();
            Step();
        }

        private void Step()
        {
            Console.WriteLine("Step");
        }
    }
}
