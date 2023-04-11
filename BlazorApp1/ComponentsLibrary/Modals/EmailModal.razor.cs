using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using ViewModelClass.EmailVMs;

namespace BlazorApp1.ComponentsLibrary.Modals
{
    public partial class EmailModal
    {
        [Inject]
        private HttpClient httpClient { get; set; }
        [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; } = default!;

        [Parameter] public string? Message { get; set; }

        

        private async Task Close() => await BlazoredModal.CloseAsync(ModalResult.Ok(true));
        private async Task Cancel() => await BlazoredModal.CancelAsync();
    }
}