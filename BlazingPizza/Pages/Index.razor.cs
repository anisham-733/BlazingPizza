using Microsoft.AspNetCore.Components;

namespace BlazingPizza.Pages
{
    public partial class Index
    {
        public List<PizzaSpecial> specials = new List<PizzaSpecial>();

        [Inject]
        public HttpClient HttpClient { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            specials = await HttpClient.GetFromJsonAsync<List<PizzaSpecial>>(NavigationManager.BaseUri + "specials");

        }


    }
}
