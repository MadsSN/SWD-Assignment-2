using System;
using Duck_Strategy;
using Duck_Decorator;
using Duck_Decorator.Base_Objects;
using Duck_Decorator.Interfaces;
using Duck_Strategy.QuackBehaviours;
using Duck_Decorator.QuackBehaviours;
namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duck testing stage");

            //Stategy first
            Console.WriteLine();
            Console.WriteLine("Stategy pattern first");

            //How to use strategy pattern
            QuackThenSqueaks quackBehaviour_Strategy = new QuackThenSqueaks();
            Duck_Strategy.Duck duck_strategy = new Duck_Strategy.Duck(quackBehaviour_Strategy);

            //Test
            duck_strategy.Quack();

            //Now Decorator pattern
            Console.WriteLine();
            Console.WriteLine("Decorator pattern");

            //How to use decorator pattern to get same behaviour as Strategy version
            IQuackBehaviour quackBehaviour_Decorator = new SqueakDecorator(new QuackDecorator(new BaseQuackBehaviour()));
            Duck_Decorator.Duck duck_decorator = new Duck_Decorator.Duck(quackBehaviour_Decorator);

            //Test
            duck_decorator.Quack();
        }
    }
}
