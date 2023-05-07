using ViewModelClass.EmailVMs;

namespace BlazorApp1.Interfaces;

public interface IHttpServiceProvider
{
    public IEmailServiceCall EmailServiceCall { get; }
}