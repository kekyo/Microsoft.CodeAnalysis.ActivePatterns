using System.Collections.Generic;

namespace SampleNamespace
{
    public sealed class SampleClass
    {
        public SampleClass()
        {
            this.Value = System.DateTime.Now.Tick;
        }

        public long Value
        {
            get;
            set;
        }
    }
}

