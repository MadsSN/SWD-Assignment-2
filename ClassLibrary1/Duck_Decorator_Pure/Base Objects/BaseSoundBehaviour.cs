using System;
using System.Collections.Generic;
using System.Text;
using Duck_Decorator_Pure.Interfaces;

namespace Duck_Decorator_Pure.Base_Objects
{
    public class BaseSoundBehaviour : ISoundBehaviour
    {
        public override void Sound()
        {
            BaseSound();
        }

        private void BaseSound()
        {

        }
    }
}
