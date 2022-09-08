using Microsoft.AspNetCore.Components;

namespace BlazorApp1.ComponentsLibrary;

public partial class CardComponent_razor
{
    //Sets up the Parameter for the component
    [Parameter] public string? HeaderOne { get; set; }
    [Parameter] public string? BodyOne { get; set; }
    [Parameter] public string? HeaderTwo { get; set; }
    [Parameter] public string? BodyTwo { get; set; }
    [Parameter] public string? HeaderThree { get; set; }
    [Parameter] public string? BodyThree { get; set; }
    
    //
    
    
}