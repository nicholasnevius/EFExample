using System;
using TestStoring.Entities;
using TestStoring;
using System.Linq;
using System.Collections.Generic;
using Test.TestStoring;
using TestStoring;

namespace TestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBoxDBNickContext dbContext = new PizzaBoxDBNickContext();
            var animal0 = dbContext.Animals.FirstOrDefault();
            var test = (from owner in dbContext.Owners
                        join animalowner in dbContext.AnimalOwners on owner.Id equals animalowner.OwnerId
                        where animalowner.AnimalId == animal0.Id
                        select owner).ToList();

            /*
            
                So this stuff should be in your mapper but I'm too lazy to make one
                This is how you would determine which derived type an object you get
                from the database


                NOTE: The .Value is only because Species is nullable. I didn't feel like dropping and
                      recreating the table.
            if ((AnimalSpecies)animal0.Species.Value is AnimalSpecies.CAT)
            {
                // Create a Test.TestDomain.Cat object
            }
            else if ((AnimalSpecies)animal0.Species is AnimalSpecies.DOG)
            {
                // Create a Test.TestDomain.Dog object
            } else
            {
                This shouldn't ever happen
            }

            */

            Console.WriteLine(animal0.Name + " is owned by:");
            test.ForEach(test => Console.WriteLine(test.Name));


            var owner0 = dbContext.Owners.FirstOrDefault();
            var test2 = (from animal in dbContext.Animals
                         join animalowner in dbContext.AnimalOwners on animal.Id equals animalowner.AnimalId
                         where animalowner.OwnerId == owner0.Id
                         select animal).ToList();

            Console.WriteLine(owner0.Name + " owns:");
            test2.ForEach(test => Console.WriteLine(test.Name));


            Console.WriteLine("Hello World!");
        }
    }
}
