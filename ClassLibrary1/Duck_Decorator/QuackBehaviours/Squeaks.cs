using System;
using System.Collections.Generic;
using System.Text;
using Duck.Interfaces;
namespace Duck_Decorator.QuackBehaviours
{
    public class Squeaks : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
