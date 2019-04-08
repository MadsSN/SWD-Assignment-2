using System;
using System.Collections.Generic;
using System.Text;

namespace Duck_Decorator.QuackBehaviours
{
    public class Quacks : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
