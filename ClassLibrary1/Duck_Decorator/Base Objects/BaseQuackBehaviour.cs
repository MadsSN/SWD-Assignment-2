using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator.Interfaces;

namespace Duck_Decorator.Base_Objects
{
    class BaseQuackBehaviour : IQuackBehaviour
    {
        public void Quack()
        {
            //Logs nothing. 
        }
    }
}
