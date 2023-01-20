using BlazorApp1.ComponentsLibrary.Modals;
using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using ViewModelClass;
using Google.Apis;

namespace BlazorApp1.Shared;

public partial class HomePageLayout
{
    [CascadingParameter] public IModalService BlazorModal { get; set; }
    
    private CardComponentVM ComponentVm { get; set; } = new CardComponentVM();
    private bool Width { get; set; } = false;

    public void SendEmail()
    {
        var options = new ModalOptions { Size = ModalSize.Medium};
        BlazorModal.Show<EmailModal>("Get in touch with us" , options );
    }

    private async Task SignInWithGoogle()
    {
        
    }
}