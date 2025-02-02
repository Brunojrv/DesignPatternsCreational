using DesignPatternsCreational.Creational.Singleton.Entities;

namespace DesignPatternsCreational.Creational.Singleton
{
    public class LockSingleton
    {
        private static Person _person { get; set; }

        private static readonly object _objectLock = new object();

        public static Person Person
        {
            get
            {
                lock (_objectLock)
                {
                    if (_person == null)
                        return Person.FactoryPerson("Bruno", "Reis", "brunoreisdev@hotmail.com", "99-999999999");

                    return _person;
                }
            }
        }
    }
}
