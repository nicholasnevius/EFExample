using System.Collections.Generic;

namespace Test.TestDomain
{
    public abstract class AAnimal
    {
        public List<Owner> Owners { get; set; }
        public string Name { get; set; }
        public abstract void MakeNoise();

        public AAnimal()
        {
            Owners = new List<Owner>();
        }

        public AAnimal(List<Owner> owners)
        {
            Owners = owners;
        }
    }
}