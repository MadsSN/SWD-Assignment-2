using System;
using System.Collections.Generic;
using System.Text;
using Duck_Strategy.Interfaces;
namespace Duck_Strategy.QuackBehaviours
{
    public class Honks : ISoundBehaviour
    {
        public override void Sound()
        {
            Console.WriteLine("Honk");
        }
    }
}
