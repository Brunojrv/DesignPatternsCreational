using DesignPatternsCreational.Creational.Singleton.Entities;

namespace DesignPatternsCreational.Creational.Singleton
{
    public static class SimpleSingleton
    {
        private static Person _person { get; set; }

        public static Person Person
        {
            get
            {
                if (_person == null)
                    _person = Person.FactoryPerson("Bruno", "Reis", "brunoreisdev@hotmail.com", "99-999999999");
                
                return _person;
            }
        }
    }
}
