using System;
using Duck_Decorator.QuackBehaviours;
using Duck_Decorator.Interfaces;

namespace Duck_Decorator
{
    public class Duck
    {
        public IQuackBehaviour QuackBehaviour { get; set; }

        public Duck(IQuackBehaviour quackBehaviour)
        {
            QuackBehaviour = quackBehaviour;
        }

        public void Quack()
        {
            QuackBehaviour.Quack();
        }
    }
}
