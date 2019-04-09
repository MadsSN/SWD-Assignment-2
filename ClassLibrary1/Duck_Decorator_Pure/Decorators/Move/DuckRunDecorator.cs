using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator_Pure.Interfaces;
using Duck_Decorator_Pure.Decorators;
namespace Duck_Decorator_Pure.QuackBehaviours
{
    public class DuckRunDecorator : DuckDecorator
    {
        public DuckRunDecorator(IDuck duck) : base(duck)
        {

        }

        public override void Move()
        {
            base.Move();
            Run();
        }

        private void Run()
        {
            Console.WriteLine("Run");
        }
    }
}
