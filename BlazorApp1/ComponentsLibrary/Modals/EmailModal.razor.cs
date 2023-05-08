using BlazorApp1.Interfaces;
using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using ViewModelClass.EmailVMs;

namespace BlazorApp1.ComponentsLibrary.Modals
{
    public partial class EmailModal
    {
        [Inject]
        private IHttpServiceProvider services { get; set; }
        private string UserEmail { get; set; }
        [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; } = default!;
        
        protected MailData mailData { get; set; } = new(new List<string>(),string.Empty,string.Empty, string.Empty,string.Empty,string.Empty,string.Empty,new List<string>(), new List<string>());
    
        [Parameter] public string? Message { get; set; }

        private async Task SendEmail()
        {
            mailData.From = "donotreply@showmerepair.com";
            mailData.To.Add("kasoftwareindustries@gmail.com");
            mailData.Subject = UserEmail;
            var response = services.EmailServiceCall.SendEmailWithUserInfo(mailData);
            if (response.IsCompleted)
            {
                Console.WriteLine("Email Sent");
            }
            await BlazoredModal.CloseAsync(ModalResult.Ok(true));

            StateHasChanged();
        }

        private async Task Close() => await BlazoredModal.CloseAsync(ModalResult.Ok(true));
        private async Task Cancel() => await BlazoredModal.CancelAsync();
    }
}