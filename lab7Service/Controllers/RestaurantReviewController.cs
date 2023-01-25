using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;
using System.Xml;
using System.Text.Json;
using System.Text;

namespace Lab7Service.Controllers
{ 
    [EnableCors]
    [Route("restaurantreview")]
    [ApiController]
    public class RestaurantReviewController : ControllerBase
    {

        private string xmlFilePath = "App_Data/restaurant.xml";

        // try the serializer method:
        private Restaurants GetRestaurantReviewsFromXML()
        {

            Restaurants restaurantReviews = new Restaurants();

            using (FileStream xs = new FileStream(this.xmlFilePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Restaurants));

                restaurantReviews = (Restaurants)serializer.Deserialize(xs);
                xs.Close();
                xs.Dispose();
            }

            return restaurantReviews;
        }

        [HttpGet] // GET request: get all restaurants from xml file:
        public List<RestaurantsInfo> Get()
        {
            GetRestaurantReviewsFromXML();

            return this.GetRestaurantsInfo();
        }

        
        [HttpGet("{id}")] // GET request: get a restaurant review with specific id:  
        public RestaurantsInfo Get(int id)
        {
            List<RestaurantsInfo> restInfosList;

            restInfosList = this.Get();

            return restInfosList[id];
        }

        
        [HttpGet("GetNames")] // GET request: get all the restaurant names and return an list of restaurant names:
        public List<String> GetRestaurantNames()
        {
            List<String> restNamesList = new List<string>();

            List<RestaurantsInfo> restsList = this.Get();

            foreach (var res in restsList)
            {
                restNamesList.Add(res.Name);
            }

            return restNamesList;
        }

        
        [HttpPost] // POST request: create a new restaurant review and save to xml
        public void PostRestaurantReview([FromBody] RestaurantsInfo newRestInfo)
        {
            // Accept and JSON string from client; Deserialize and save in XML
            //RestaurantsInfo newRestInfo = JsonConvert.DeserializeObject<RestaurantsInfo>(restInfoString);

            Restaurants resReviews = GetRestaurantReviewsFromXML();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var reviewsList = resReviews.Restaurant.ToList();

            RestaurantsRestaurant newRes = new RestaurantsRestaurant();
            newRes.Name = newRestInfo.Name;
            newRes.Summary = newRestInfo.Summary;
            newRes.Rating = newRestInfo.Rating;
            newRes.Price = newRestInfo.Cost;

            newRes.Address = new Address();
            newRes.Address.Street = newRestInfo.Location.Street;
            newRes.Address.City = newRestInfo.Location.City;

            reviewsList.Add(newRes);
            //reviewsList.ToArray();

            Restaurants restaurantsXML = new Restaurants();
            restaurantsXML.Restaurant = reviewsList.ToArray();

            SaveRestaurantReviewsToXml(restaurantsXML);

            #region: xmlWrite
            /*XmlDocument doc = new XmlDocument();

            string xmlFilePath = Path.GetFullPath("App_Data/restaurant.xml");
            doc.Load(xmlFilePath);

            XmlElement Restaurant = doc.CreateElement("Restaurant");
            Restaurant.SetAttribute("type", newRestInfo.FoodType);

            XmlNode Name = doc.CreateElement("Name");
            Name.InnerText = newRestInfo.Name;
            Restaurant.AppendChild(Name);

            // rating
            XmlNode Rating = doc.CreateElement("Rating");
            Rating.InnerText = newRestInfo.Rating.ToString();
            Restaurant.AppendChild(Rating);

            // price
            XmlNode Price = doc.CreateElement("Price");
            Price.InnerText = newRestInfo.Cost;
            Restaurant.AppendChild(Price);

            // summary
            XmlNode Summary = doc.CreateElement("Summary");
            Summary.InnerText = newRestInfo.Summary;
            Restaurant.AppendChild(Summary);

            // location address:
            XmlNode Address = doc.CreateElement("Address");
            XmlNode Street = doc.CreateElement("Street");
            Street.InnerText = newRestInfo.Location.Street;
            Address.AppendChild(Street);

            XmlNode City = doc.CreateElement("City");
            City.InnerText = newRestInfo.Location.City;
            Address.AppendChild(City);

            XmlNode Province = doc.CreateElement("Province");
            Province.InnerText = newRestInfo.Location.Province;
            Address.AppendChild(Province);

            XmlNode Zip = doc.CreateElement("Zip");
            Zip.InnerText = newRestInfo.Location.PostalCode;
            Address.AppendChild(Zip);

            Restaurant.AppendChild(Address);

            doc.ChildNodes[1].AppendChild(Restaurant);

            doc.Save(xmlFilePath);*/

            #endregion
        }

        private void SaveRestaurantReviewsToXml(Restaurants reviews)
        {
            XmlSerializer serializor = new XmlSerializer(typeof(Restaurants));
            XmlTextWriter tw = new XmlTextWriter(this.xmlFilePath, Encoding.UTF8);
            serializor.Serialize(tw, reviews);
            tw.Close();
        }

        [HttpPut("{id}")] // PUT request: update a restaurant review in the xml file:
        public void UpdateRestaurantReview(int id, [FromBody] RestaurantsInfo newRestInfo)
        {
            this.DeleteRestaurantReview(id);

            this.PostRestaurantReview(newRestInfo);
        }

        
        [HttpDelete("{id}")] // DELETE request: delete the record in xml
        public void DeleteRestaurantReview(int id)
        {
            // load the xml file first:
            string xmlFilePath = Path.GetFullPath("App_Data/restaurant.xml");

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);

            doc.DocumentElement.RemoveChild(doc.DocumentElement.ChildNodes[id]);
            doc.Save(xmlFilePath);
        }

        #region xmlMethod

        // Create a method GetRestaurantInfo(): load the xml file and return a list of RestaurantsInfo objects
        private List<RestaurantsInfo> GetRestaurantsInfo()
        {
            // load the xml file first:
            string xmlFilePath = Path.GetFullPath("App_Data/restaurant.xml");

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);

            List<RestaurantsInfo> restsInfosList = new List<RestaurantsInfo>();

            XmlNodeList restaurantChildNodes = doc.LastChild.ChildNodes;

            int IdNumber = 0;

            foreach (XmlNode node in restaurantChildNodes)
            {
                restsInfosList.Add(new RestaurantsInfo
                {
                    Id = IdNumber,
                    Name = node["Name"].InnerText,
                    Rating = decimal.Parse(node["Rating"].InnerText),
                    Cost = node["Price"].InnerText,
                    Summary = node["Summary"].InnerText,
                    FoodType = node.Attributes[0].Value,

                    Location = new AddressInfo()
                    {
                        Street = node["Address"]["Street"].InnerText,
                        City = node["Address"]["City"].InnerText,
                        Province = node["Address"]["Province"].InnerText,
                        PostalCode = node["Address"]["Zip"].InnerText
                    }
                }); ;

                IdNumber++;
            }

            return restsInfosList;
            
        }
        #endregion
    }
}
