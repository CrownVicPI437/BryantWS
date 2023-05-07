using ViewModelClass.EmailVMs;

namespace BlazorApp1.Interfaces;

public interface IEmailServiceCall
{
    Task<MailData> SendEmailWithUserInfo(MailData mailDatas);
}