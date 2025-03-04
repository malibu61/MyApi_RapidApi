using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Collections.Generic;

namespace RapidApiConsume.Controllers
{
    public class BookingController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //using System.Net.Http.Headers;

            List<BookingViewModel.Hotel> _bookingViewModel = new List<BookingViewModel.Hotel>();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id=-2601889&search_type=CITY&arrival_date=2025-02-16&departure_date=2025-02-21&adults=1&children_age=0%2C17&room_qty=1&page_number=1&units=metric&temperature_unit=c&languagecode=en-us&currency_code=TRY"),
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
                var values = JsonConvert.DeserializeObject<BookingViewModel.Rootobject>(body);
                //_bookingViewModel = values?.?.hotels?.ToList() ?? new List<BookingViewModel.Hotel>();
                _bookingViewModel = values?.data.hotels.ToList();

                return View(_bookingViewModel);
            }
        }
    }
}
