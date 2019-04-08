﻿using System;
using System.Collections.Generic;
using System.Text;
using Duck_Strategy.Interfaces;

namespace Duck_Strategy.QuackBehaviours
{
    public class SqueakThenQuacks : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak, Quack");
        }
    }
}
