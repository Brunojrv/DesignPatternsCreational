using DesignPatternsCreational.Creational.Entities.Interface;

namespace DesignPatternsCreational.Creational.Singleton.Entities
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public static Person FactoryPerson(string name, string lastName, string email, string phone)
        {
            return new Person
            {
                Name = name,
                LastName = lastName,
                Email = email,
                Phone = phone,
            };
        }
    }
}
