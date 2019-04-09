using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Duck_Decorator_Pure.Interfaces;

namespace Duck_Decorator_Pure.Decorators
{
    public abstract class SoundBehaviourDecorator : ISoundBehaviour
    {
        private ISoundBehaviour _soundBehaviour;

        protected SoundBehaviourDecorator(ISoundBehaviour soundBehaviour)
        {
            _soundBehaviour = soundBehaviour;
        }

        public override void Sound()
        {
            _soundBehaviour.Sound();
        }
    }
}
