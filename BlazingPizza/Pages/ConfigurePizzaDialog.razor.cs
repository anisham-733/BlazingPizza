using Microsoft.AspNetCore.Components;

namespace BlazingPizza.Pages
{
    public partial class ConfigurePizzaDialog
    {
        [Parameter] public Pizza Pizza { get; set; }
        [Parameter] public EventCallback OnCancel { get; set; }
        [Parameter] public EventCallback OnConfirm { get; set; }
    }
}
