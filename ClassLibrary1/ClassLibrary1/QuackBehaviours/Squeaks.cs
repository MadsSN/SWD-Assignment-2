﻿using System;
using System.Collections.Generic;
using System.Text;
using Duck_Strategy.Interfaces;
namespace Duck_Strategy.QuackBehaviours
{
    public class Squeaks : IQuackBehaviour
    {
        public override void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
