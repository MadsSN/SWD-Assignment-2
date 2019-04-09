using System;
using System.Collections.Generic;
using System.Text;
using Duck_Strategy.Interfaces;
namespace Duck_Strategy.QuackBehaviours
{
    public class Squeaks : ISoundBehaviour
    {
        public override void Sound()
        {
            Console.WriteLine("Squeak");
        }
    }
}
