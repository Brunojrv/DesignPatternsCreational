using DesignPatternsCreational.Creational.Build.Interface;
using DesignPatternsCreational.Creational.Entities.Interface;
using DesignPatternsCreational.Creational.Singleton.Entities;
using System.Xml.Linq;

namespace DesignPatternsCreational.Creational.Build.SimpleBuild
{
    public class PersonSimpleBuild : IPersonSimpleBuild, IPerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        private PersonSimpleBuild _personSimpleBuild;

        public PersonSimpleBuild()
        {
            _personSimpleBuild = new PersonSimpleBuild();
        }
       
        public void SetEmail(string email)
        {
            _personSimpleBuild.Email = email;
        }

        public void SetLastName(string lastName)
        {
            _personSimpleBuild.LastName = lastName;
        }

        public void SetName(string name)
        {
            _personSimpleBuild.Name = name;

        }

        public void SetPhone(string phone)
        {
            _personSimpleBuild.Phone = phone;
        }

        public PersonSimpleBuild Build()
        {
            return _personSimpleBuild;
        }
    }
}
