﻿using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator.Decorators;
using Duck_Decorator.Interfaces;

namespace Duck_Decorator.QuackBehaviours
{
    public class SqueakDecorator : QuackBehaviourDecorator
    {
        public SqueakDecorator(IQuackBehaviour quackBehaviour) : base(quackBehaviour)
        {

        }

        public void Quack()
        {
            base.Quack();
            Console.WriteLine("Squeak");
        }
    }
}
