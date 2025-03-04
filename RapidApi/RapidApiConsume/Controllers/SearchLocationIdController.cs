using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationIdController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            if(!string.IsNullOrEmpty(cityName))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={cityName}"),
                    Headers =
    {
        { "x-rapidapi-key", "b2ee40a4ecmsh77e478a1519f5e2p17fd5ejsn383af503e7df" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    var values = JsonConvert.DeserializeObject<BookingApiLocationSearchViewModel.Rootobject>(body);
                    var _bookingApiLocationSearchViewModels = values?.data?.ToList() ?? new List<BookingApiLocationSearchViewModel.Datum>();

                    return View(_bookingApiLocationSearchViewModels?.Take(1).ToList());
                }
            }
            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query=paris"),
                    Headers =
    {
        { "x-rapidapi-key", "b2ee40a4ecmsh77e478a1519f5e2p17fd5ejsn383af503e7df" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    var values = JsonConvert.DeserializeObject<BookingApiLocationSearchViewModel.Rootobject>(body);
                    var _bookingApiLocationSearchViewModels = values?.data?.ToList() ?? new List<BookingApiLocationSearchViewModel.Datum>();

                    return View(_bookingApiLocationSearchViewModels?.Take(1).ToList());
                }
            }
           
        }
    }
}
