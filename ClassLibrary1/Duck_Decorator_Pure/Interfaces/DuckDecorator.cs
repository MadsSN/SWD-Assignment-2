using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Duck_Decorator.Interfaces;

namespace Duck_Decorator_Pure.Decorators
{
    public abstract class DuckDecorator : IDuck
    {
        private IDuck _duck;

        protected DuckDecorator(IDuck duck)
        {
            _duck = duck;
        }

        public override void Sound()
        {
            _duck.Sound();
        }
    }
}
