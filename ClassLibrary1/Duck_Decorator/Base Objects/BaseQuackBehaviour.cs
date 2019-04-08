using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator.Interfaces;

namespace Duck_Decorator.Base_Objects
{
    public class BaseQuackBehaviour : IQuackBehaviour
    {
        public override void Quack()
        {
            //Logs nothing. 
        }
    }
}
