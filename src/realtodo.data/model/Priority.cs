using System;

namespace realtodo.data.model
{
    public class Priority
    {
        public virtual long PriorityId { get; set; }
        public virtual string Name { get; set; }
        public virtual int Oridinal { get; set; }
        public virtual byte[] Version { get; set; }
    }
}
