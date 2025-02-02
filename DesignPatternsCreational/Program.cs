using DesignPatternsCreational.Creational.Build.FluentBuild;
using DesignPatternsCreational.Creational.Build.SimpleBuild;
using DesignPatternsCreational.Creational.Factory.SimpleFactory;
using DesignPatternsCreational.Creational.Prototype.ValueObject;
using DesignPatternsCreational.Creational.Singleton;
using DesignPatternsCreational.Domain.Entities.PersonByPrototype;
using DesignPatternsCreational.Domain.Entities.PlanCreator;
using DesignPatternsCreational.Domain.Enum.Plan;
using System;
using System.Threading.Tasks;

namespace DesignPatternsCreational
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Singleton 
            //var objectAretheSame = CaseSingleton();
            //Console.WriteLine($"Os objetos comparados são iguais? - {objectAretheSame}");

            //SingletonLock
            // CaseSingletonLock();

            //SingletonLazy
            //CaseSingletonLazy();


            //Builder
            //var fluentBuild =FluentBuild();
            //var simpleBuild = SimpleBuild();

            //Factory
            //SimpleFactory();
            //FactoryMethod();

            //Prototype

            PersonPrototype();
        }


        #region Singleton
        public static void CaseSingletonLazy()
        {
            Parallel.For(0, 100, new ParallelOptions { MaxDegreeOfParallelism = 10 },
             i =>
             {
                 var instance = LazySingleton.Instance;
             });

            Console.WriteLine("Processamento concluído. Pressione qualquer tecla para sair.");
            Console.ReadKey();


        }

        public static bool CaseSingleton()
        {
            var personOne = SimpleSingleton.Person;
            var personTwo = SimpleSingleton.Person;

            var isEquals = personOne.Equals(personTwo);
            return isEquals;
        }

        public static void CaseSingletonLock()
        {
            Parallel.For(0, 100, new ParallelOptions { MaxDegreeOfParallelism = 10 },
              i =>
              {
                  var person = LockSingleton.Person;
              });

            Console.WriteLine("Processamento concluído. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }

        #endregion

        #region Builder
        public static PersonFluentBuild FluentBuild()
        {
            var personFluentBuild = new PersonFluentBuild().SetEmail("brunoreisdev@hotmail.com")
                .SetLastName("reis")
                .SetName("bruno")
                .SetPhone("99-999999999")
                .Build();

            return personFluentBuild;
        }

        public static PersonSimpleBuild SimpleBuild()
        {
            var personFluentBuild = new PersonSimpleBuild();
            personFluentBuild.SetEmail("brunoreisdev@hotmail.com");
            personFluentBuild.SetLastName("reis");
            personFluentBuild.SetName("bruno");
            personFluentBuild.SetPhone("99-999999999");
            personFluentBuild.Build();

            return personFluentBuild;
        }
        #endregion

        #region Factory
        public static void SimpleFactory()
        {
            var simpleFactory = new SimpleFactory();

            var planOne = simpleFactory.SimpleFactoryPlan(EnumTypePlan.PlanOne, 1000, "Plano um");
            var planTwo = simpleFactory.SimpleFactoryPlan(EnumTypePlan.PlanTwo, 1000, "Plano dois");

            Console.WriteLine($"Plano um instanciado:  {planOne.NamePlan}");
            Console.WriteLine($"Plano dois instanciado: {planTwo.NamePlan}");
        }

        public static void FactoryMethod()
        {
            var planOneCreator = new PlanOneCreator();
            var planTwoCreator = new PlanTwoCreator();

            planOneCreator.CreatePlan(EnumTypePlan.PlanOne, 1000, "Plano um");
            planTwoCreator.CreatePlan(EnumTypePlan.PlanTwo, 1000, "Plano um");
        }

        #endregion

        #region Prototype

        public static void PersonPrototype()
        {
            var address = new Address("Camaragibe", "Via Coletora");
            var personPrototype = new PersonPrototype("Bruno", 29, address);

            var personClone = personPrototype.Clone();

            Console.WriteLine($"Cidade doObjeto clonado: {personClone.Address.City}");
        }
        #endregion
    }
}
