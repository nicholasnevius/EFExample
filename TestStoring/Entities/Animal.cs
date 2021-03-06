using System;
using System.Collections.Generic;

#nullable disable

namespace TestStoring.Entities
{
    public partial class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Species { get; set; }
        public ICollection<Owner> Owners { get; set; }
    }
}
