using DesignPatternsCreational.Creational.Build.Interface;
using DesignPatternsCreational.Creational.Entities.Interface;

namespace DesignPatternsCreational.Creational.Build.FluentBuild
{
    public class PersonFluentBuild : IPersonFluentBuild, IPerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

     
        public PersonFluentBuild SetEmail(string email)
        {
            Email = email;
            return this;
        }

        public PersonFluentBuild SetLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }

        public PersonFluentBuild SetName(string name)
        {
            Name = name;
            return this;
        }

        public PersonFluentBuild SetPhone(string phone)
        {
            Phone = phone;
            return this;
        }

        public PersonFluentBuild Build()
        {
            return this;
        }
    }
}
