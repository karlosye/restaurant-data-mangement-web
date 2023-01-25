using System.Diagnostics;
using System.Net;
/*using System.Text;
using System.Text.Json;*/
using lab7Client.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace lab7Client.Controllers
{
    public class HomeController : Controller
    {
        private string serviceURL = "http://localhost/restaurantreviewservices/restaurantreview";

        public IActionResult Index()
        {
            HttpClient httpClient = new HttpClient();

            using var response = httpClient.GetAsync(serviceURL).Result;

            // check if response code is okay -> see if the http request is successful
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string apiResponse = response.Content.ReadAsStringAsync().Result;

                List<RestaurantsInfo> restInfosList = JsonConvert.DeserializeObject<List<RestaurantsInfo>>(apiResponse);               

                return View(restInfosList);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult Create()
        {
            Console.WriteLine("Redirecting to the create restaurant review page...");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewRestaurantReview(RestaurantsInfo rest)
        {
            Console.WriteLine("Creating a new restaurant review....");

            // create a new HTTP post request:
            HttpClient httpClient = new HttpClient();

            string restInfoString = JsonConvert.SerializeObject(rest);

            StringContent content = new StringContent(restInfoString, System.Text.Encoding.UTF8, "application/json");

            using HttpResponseMessage response = await httpClient.PostAsync(this.serviceURL + "/" + "PostRestaurantReview", content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        public ActionResult Delete(int? id)
        {
            Console.WriteLine("Delete request detected");
            Console.WriteLine(id);

            HttpClient httpClient = new HttpClient();

            using var response = httpClient.DeleteAsync(this.serviceURL + "/" + "DeleteRestaurantReview?id=" + id.ToString()).Result;

            Console.WriteLine(response.StatusCode);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return RedirectToAction("Index");

            } else
            {
                return RedirectToAction("Error");
            }
        }

        public ActionResult Edit(int id)
        {
            Console.WriteLine(id);

            HttpClient httpClient = new HttpClient();

            using var response = httpClient.GetAsync(serviceURL).Result;

            // check if response code is okay -> see if the http request is successful
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string apiResponse = response.Content.ReadAsStringAsync().Result;

                List<RestaurantsInfo> restInfosList = JsonConvert.DeserializeObject<List<RestaurantsInfo>>(apiResponse);

                return View(restInfosList[id]);
            }
            else
            {
                return RedirectToAction("Error"); 
            }
        }

        [HttpPost]
        public IActionResult EditRestaurantReview(RestaurantsInfo restInfo)
        {
            Console.WriteLine(restInfo.Id);

            HttpClient httpClient = new HttpClient();

            string restInfoString = JsonConvert.SerializeObject(restInfo);

            StringContent content = new StringContent(restInfoString, System.Text.Encoding.UTF8, "application/json");

            using var response = httpClient.PutAsync(serviceURL + "/" + "UpdateRestaurantReview?id=" + restInfo.Id.ToString(), content).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}