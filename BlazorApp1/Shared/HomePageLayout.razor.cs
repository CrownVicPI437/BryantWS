using BlazorApp1.ComponentsLibrary.Modals;
using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using ViewModelClass;

namespace BlazorApp1.Shared;

public partial class HomePageLayout
{
    private CardComponentVM ComponentVm { get; set; } = new CardComponentVM();
    private bool Width { get; set; } = false;

    public void SendEmail()
    {
        
    }
}