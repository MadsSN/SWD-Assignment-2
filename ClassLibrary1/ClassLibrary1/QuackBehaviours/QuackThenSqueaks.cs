﻿using System;
using System.Collections.Generic;
using System.Text;
using Duck_Strategy.Interfaces;
namespace Duck_Strategy.QuackBehaviours
{
    public class QuackThenSqueaks : Quacks
    {
        public override void Quack()
        {
            base.Quack();
            Console.WriteLine("Squeak");
        }
    }
}
