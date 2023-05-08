using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using BlazorApp1.Interfaces;
using Newtonsoft.Json;
using ViewModelClass.EmailVMs;

namespace BlazorApp1.Services;

public class EmailServiceCall : IEmailServiceCall
{
    public readonly HttpClient _httpClient;
    private Uri _url;

    public EmailServiceCall(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("http://jcbryantws-001-site1.atempurl.com/");
        
    }
    
    public async Task<MailData> SendEmailWithUserInfo(MailData mailDatas)
    {
        MailData mailData = new(new List<string>(),string.Empty,string.Empty, string.Empty,string.Empty,string.Empty,string.Empty,new List<string>(), new List<string>());
        var MailConent = new StringContent(System.Text.Json.JsonSerializer.Serialize(mailDatas), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("api/Mail/sendmail", MailConent);
        if (response.IsSuccessStatusCode)
        {
            var responsestring = await response.Content.ReadAsStringAsync();
                mailData = System.Text.Json.JsonSerializer.Deserialize<MailData>(responsestring,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = false }) ?? throw new InvalidOperationException();
        }

        return mailData;
    }

    public async Task SendAutomatedEmailResponse()
    {
        
    }

    public async Task SendEmailWithAttachment()
    {
        
    }
}