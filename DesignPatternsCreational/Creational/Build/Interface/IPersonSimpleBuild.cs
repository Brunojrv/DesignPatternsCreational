using DesignPatternsCreational.Creational.Build.SimpleBuild;

namespace DesignPatternsCreational.Creational.Build.Interface
{
    public interface IPersonSimpleBuild
    {
        void SetName(string name);

        void SetLastName(string lastName);
        
        void SetEmail(string email);
        
        void SetPhone(string phone);

        PersonSimpleBuild Build();
    }
}
