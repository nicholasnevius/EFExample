using System.Collections.Generic;

namespace Test.TestDomain
{
    public class Owner
    {
        public List<AAnimal> Animals { get; set; }
        public string Name { get; set; }

        public Owner()
        {
            Animals = new List<AAnimal>();
        }

        public Owner(List<AAnimal> animals, string name)
        {
            Animals = animals;
            Name = name;
        }
    }
}