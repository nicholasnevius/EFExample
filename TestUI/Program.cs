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
            var animal0_owners = dbContext.AnimalOwners.Where(ao => ao.AnimalId == animal0.Id).ToList();
            Console.WriteLine(animal0.Name + " is owned by:");
            animal0_owners.ForEach(test => Console.WriteLine(test.Owner.Name));


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



            var owner0 = dbContext.Owners.FirstOrDefault();
            var owner0_animals = dbContext.AnimalOwners.Where(ao => ao.OwnerId == owner0.Id).ToList();
            Console.WriteLine(owner0.Name + " owns:");
            owner0_animals.ForEach(test => Console.WriteLine(test.Animal.Name));


            Console.WriteLine("Hello World!");
        }
    }
}
