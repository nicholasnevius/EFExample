using System;
using System.Collections.Generic;

#nullable disable

namespace TestStoring.Entities
{
    public partial class Store
    {
        public string Name { get; set; }
        public double? Ratings { get; set; }
        public string Description { get; set; }
    }
}
