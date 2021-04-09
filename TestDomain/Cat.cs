using System;
using System.Collections.Generic;

namespace Test.TestDomain
{
    public class Cat : AAnimal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Meow");
        }

        public Cat()
        {
            Name = "Cat";
        }

        public Cat(List<Owner> owners) : base(owners)
        {
            Name = "Cat";
        }
    }
}