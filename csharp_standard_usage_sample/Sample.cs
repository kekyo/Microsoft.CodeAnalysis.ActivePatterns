using System.Collections.Generic;

namespace SampleNamespace
{
    public sealed class SampleClass
    {
        public SampleClass()
        {
            this.Value = System.DateTime.Now.Ticks;
        }

        public long Value
        {
            get;
            set;
        }
    }
}

