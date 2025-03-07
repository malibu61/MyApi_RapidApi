using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.DashboardSocialMediasDto;

namespace WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            //Instagram
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/egekoypazarii"),
                Headers =
    {
        { "x-rapidapi-key", "b2ee40a4ecmsh77e478a1519f5e2p17fd5ejsn383af503e7df" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                InstagramInfoDto instagramInfoDto = JsonConvert.DeserializeObject<InstagramInfoDto>(body);
                ViewBag.v1 = instagramInfoDto?.followers;
                ViewBag.v2 = instagramInfoDto?.media_count;//Gönderi sayısı
                //ViewBag.v3 = instagramInfoDto?.lastMedia.media[0]?.like;//Son gönderi beğeni sayısı
            }








            //Linkedn

            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fmuhammet-ali-tanr%C4%B1kulu-8a8959293%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false&include_profile_status=false&include_company_public_url=false"),
                Headers =
    {
        { "x-rapidapi-key", "b2ee40a4ecmsh77e478a1519f5e2p17fd5ejsn383af503e7df" },
        { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response2 = await client.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                LinkednInfoDto linkednInfoDto = JsonConvert.DeserializeObject<LinkednInfoDto>(body2);
                ViewBag.v3 = linkednInfoDto?.data.connection_count;//bağlantı sayısı
                ViewBag.v4 = linkednInfoDto?.data.follower_count;// takipçi sayısı
            }


















            //Twitter

            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter-api45.p.rapidapi.com/screenname.php?screenname=GalatasaraySK"),
                Headers =
    {
        { "x-rapidapi-key", "b2ee40a4ecmsh77e478a1519f5e2p17fd5ejsn383af503e7df" },
        { "x-rapidapi-host", "twitter-api45.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                TwitterInfoDto twitterInfoDto = JsonConvert.DeserializeObject<TwitterInfoDto>(body3);
                ViewBag.v5 = twitterInfoDto?.sub_count;//Takipçiler
                ViewBag.v6 = twitterInfoDto?.friends;//Takip edilen
                }


            return View();
        }
    }
}
