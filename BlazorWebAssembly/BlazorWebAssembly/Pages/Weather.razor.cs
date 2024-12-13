using BlazorWebAssembly.Models;
using System.Net.Http.Json;

namespace BlazorWebAssembly.Pages;

public partial class Weather
{
    public string Name { get; set; }
    private WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }
}
