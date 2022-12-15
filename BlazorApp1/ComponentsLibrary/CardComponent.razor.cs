using Microsoft.AspNetCore.Components;
using ViewModelClass;

namespace BlazorApp1.ComponentsLibrary
{
    public partial class CardComponent
    {
        [Parameter] public string? HeaderOne { get; set; }
        [Parameter] public string? BodyOne { get; set; }
        [Parameter] public string? HeaderTwo { get; set; }
        [Parameter] public string? BodyTwo { get; set; }
        [Parameter] public string? HeaderThree { get; set; }
        [Parameter] public string? BodyThree { get; set; }

        public CardComponentVM ComponentVm { get; set; } = new CardComponentVM();

        public void EditMethod()
        {
            
        }

        public void UpdateContext()
        {
            
        }

        public void UpdateImages()
        {
            
        }
    }
}