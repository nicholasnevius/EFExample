using System;
using System.Collections.Generic;

#nullable disable

namespace TestStoring.Entities
{
    public partial class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
