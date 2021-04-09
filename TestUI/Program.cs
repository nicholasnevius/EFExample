using System;
using TestStoring.Entities;
using TestStoring;
using System.Linq;
using System.Collections.Generic;


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

            Console.WriteLine(animal0.Name + " is owned by:");
            test.ForEach(test => Console.WriteLine(test.Name));

            var owner0 = dbContext.Owners.FirstOrDefault();
            var test2 = (from animal in dbContext.Animals
                         join animalowner in dbContext.AnimalOwners on animal.Id equals animalowner.AnimalId
                         where animalowner.OwnerId == owner0.Id
                         select animal).ToList();

            Console.WriteLine(owner0.Name + " owns:");
            test2.ForEach(test => Console.WriteLine(test.Name));

        }
    }
}
