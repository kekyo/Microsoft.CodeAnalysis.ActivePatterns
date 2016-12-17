using System;

namespace SampleNamespace
{
    public sealed class SampleClass
    {
        public SampleClass()
        {
            this.Value = DateTime.Now.Tick;
        }

        public long Value
        {
            get;
            set;
        }
    }
}

