﻿using System;
using System.Collections.Generic;
using System.Text;
using Duck_Strategy.Interfaces;

namespace Duck_Strategy.QuackBehaviours
{
    public class HonksThenQuacks : Honks
    {
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Quack");
        }
    }
}
