using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Duck_Decorator_Pure.Interfaces;

namespace Duck_Decorator_Pure.Decorators
{
    public abstract class DuckDecorator : IDuck
    {
        private IDuck _duck;

        protected DuckDecorator(IDuck duck)
        {
            _duck = duck;
        }

        public virtual void Sound()
        {
            _duck.Sound();
        }

        public virtual void Movement()
        {
            _duck.Movement();
        }
    }
}
