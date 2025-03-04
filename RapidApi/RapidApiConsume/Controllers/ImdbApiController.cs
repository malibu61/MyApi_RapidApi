using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Text.Json.Serialization;

namespace RapidApiConsume.Controllers
{
    public class ImdbApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //using System.Net.Http.Headers;

            List<ImdbApiViewModel> _imdbApiViewModels = new List<ImdbApiViewModel>();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "x-rapidapi-key", "b2ee40a4ecmsh77e478a1519f5e2p17fd5ejsn383af503e7df" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                _imdbApiViewModels = JsonConvert.DeserializeObject<List<ImdbApiViewModel>>(body);

                return View(_imdbApiViewModels);
            }
        }
    }
}
