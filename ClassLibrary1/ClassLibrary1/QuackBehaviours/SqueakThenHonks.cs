using System;
using System.Collections.Generic;
using System.Text;
using DDuck_Strategyuck.Interfaces;
namespace Duck_Strategy.QuackBehaviours
{
    public class SqueakThenHonks : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak, Honk");
        }
    }
}
