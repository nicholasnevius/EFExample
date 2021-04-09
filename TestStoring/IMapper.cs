using TestStoring.Entities;
using Test.TestDomain;

namespace Test.TestStoring
{
    public interface IMapper
    {

        public Animal Map(Test.TestDomain.AAnimal animal);
        public Test.TestDomain.AAnimal Map(Animal animal);
    }
}