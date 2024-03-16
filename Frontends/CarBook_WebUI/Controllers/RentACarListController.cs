using CarBook_Dto.BrandDtos;
using CarBook_Dto.RentACarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace CarBook_WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RentACarListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int id)
        {
            var locationId = TempData["locationId"];
            //if (locationId != null)
            //{
            //    id = int.Parse(locationId.ToString());
            //}
            // filterRentACarDto.LocationId = int.Parse(locationId.ToString());
            // filterRentACarDto.Avaiable = true;
            id = int.Parse(locationId.ToString());

            ViewBag.locationId = locationId;

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7117/api/RentACar?LocationId={id}&avaiable=true");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(jsonData);
                return View(values);
            }
            return View();
            

        }
    }
}
