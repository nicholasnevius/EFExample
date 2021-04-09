using System;
using System.Collections.Generic;

namespace Test.TestDomain
{
    public class Dog : AAnimal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Woof");
        }

        public Dog()
        {
            Name = "Dog";
        }

        public Dog(List<Owner> owners) : base(owners)
        {
            Name = "Dog";
        }
    }
}