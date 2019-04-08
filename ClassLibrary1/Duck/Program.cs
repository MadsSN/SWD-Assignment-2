using System;
using Duck_Strategy;
using Duck_Decorator;
using Duck_Strategy.QuackBehaviours;

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
            QuackThenSqueaks quackbehaviour_Strategy = new QuackThenSqueaks();
            Duck_Strategy.Duck duck_strategy = new Duck_Strategy.Duck(quackbehaviour_Strategy);

            //Test
            duck_strategy.Quack();

        }
    }
}
