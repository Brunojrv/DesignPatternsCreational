using DesignPatternsCreational.Creational.Build.FluentBuild;

namespace DesignPatternsCreational.Creational.Build.Interface
{
    public interface IPersonFluentBuild
    {
        PersonFluentBuild SetName(string name);

        PersonFluentBuild SetLastName(string lastName);

        PersonFluentBuild SetEmail(string email);

        PersonFluentBuild SetPhone(string phone);

        PersonFluentBuild Build();
    }
}
