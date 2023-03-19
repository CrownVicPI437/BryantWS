using ViewModelClass.EmailVMs;

namespace BryantWeb.Api.Interface;

public interface IMailService
{
    Task<bool> SendAsync(MailData mailData, CancellationToken ct);
}