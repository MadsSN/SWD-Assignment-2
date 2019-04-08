using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Duck_Decorator.Interfaces;

namespace Duck_Decorator.Decorators
{
    public abstract class QuackBehaviourDecorator : IQuackBehaviour
    {
        private IQuackBehaviour _quackBehaviour;

        protected QuackBehaviourDecorator(IQuackBehaviour quackBehaviour)
        {
            _quackBehaviour = quackBehaviour;
        }

        public void Quack()
        {
            _quackBehaviour.Quack();
        }
    }
}
