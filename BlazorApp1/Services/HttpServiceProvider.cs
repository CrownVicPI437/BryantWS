using BlazorApp1.Interfaces;

namespace BlazorApp1.Services;

public class HttpServiceProvider : IHttpServiceProvider
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public HttpServiceProvider(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    private EmailServiceCall _emailServiceCall;

    public IEmailServiceCall EmailServiceCall
    {
        get
        {
            {
                return _emailServiceCall ?? (_emailServiceCall = new EmailServiceCall(_httpClient));
            }
        }
    }
}