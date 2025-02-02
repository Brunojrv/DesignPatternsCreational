using DesignPatternsCreational.Creational.Prototype.Interface;
using DesignPatternsCreational.Creational.Prototype.ValueObject;

namespace DesignPatternsCreational.Domain.Entities.PersonByPrototype
{
    public class PersonPrototype : IPrototype<PersonPrototype>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Address Address { get; set; }

        public PersonPrototype(string name, int age, Address address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public PersonPrototype Clone()
        {
            var clone = (PersonPrototype)MemberwiseClone();
            clone.Address = Address.Clone();

            return clone;
        }
    }
}
