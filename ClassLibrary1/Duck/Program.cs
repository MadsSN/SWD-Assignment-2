using System;
using Duck_Strategy;
using Duck_Decorator;
using Duck_Decorator.Base_Objects;
using Duck_Decorator.Interfaces;
using Duck_Strategy.QuackBehaviours;
using Duck_Decorator_Pure.QuackBehaviours;
using QuackSoundDecorator = Duck_Decorator.QuackBehaviours.QuackSoundDecorator;
using SqueakSoundDecorator = Duck_Decorator.QuackBehaviours.SqueakSoundDecorator;

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
            QuackThenSqueaks quackBehaviourStrategy = new QuackThenSqueaks();
            Duck_Strategy.Duck duck_strategy = new Duck_Strategy.Duck(quackBehaviourStrategy);

            //Test
            duck_strategy.Quack();

            //Now Decorator pattern
            Console.WriteLine();
            Console.WriteLine("Decorator pattern");

            //How to use decorator pattern to get same behaviour as Strategy version
            ISoundBehaviour soundBehaviourDecorator = new SqueakSoundDecorator(new QuackSoundDecorator(new BaseSoundBehaviour()));
            Duck_Decorator.Duck duck_decorator = new Duck_Decorator.Duck(soundBehaviourDecorator);

            //Test
            duck_decorator.Quack();

            //Now pure decorator pattern
            //Now Decorator pattern
            Console.WriteLine();
            Console.WriteLine("Pure Decorator pattern");

            //How to use decorator pattern to get same behaviour as Strategy version
            IDuck duck = new HonkDuckDecorator(new Duck_Decorator_Pure.Duck());

            //Test
            duck.Sound();
        }
    }
}
