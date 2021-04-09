using System;
using System.Collections.Generic;

#nullable disable

namespace TestStoring.Entities
{
    public partial class AnimalOwner
    {
        public int AnimalId { get; set; }
        public int OwnerId { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual Owner Owner { get; set; }
    }
}
