using DesignPatternsCreational.Creational.Singleton.Entities;
using System;

namespace DesignPatternsCreational.Creational.Singleton
{
    public class LazySingleton
    {
        public static Person Instance => LazyPerson.Value;

        private static Lazy<Person>  LazyPerson =
            new Lazy<Person>(() => Person.FactoryPerson("Bruno", "Reis", "brunoreisdev@hotmail.com", "99-999999999"));
    }
}
