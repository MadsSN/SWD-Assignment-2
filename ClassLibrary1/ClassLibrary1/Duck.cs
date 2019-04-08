using System;
using Duck_Strategy.QuackBehaviours;
using Duck_Strategy.Interfaces;
namespace Duck_Strategy
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
