using System.Runtime.Serialization;

namespace Lab7Service
{
    public class RestaurantsInfo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Summary { get; set; }

        [DataMember]
        public decimal Rating { get; set; }

        [DataMember]
        public AddressInfo Location { get; set; }

        [DataMember]
        public string FoodType { get; set; }

        [DataMember]
        public string Cost { get; set; }
    }

    [DataContract]
    public class AddressInfo
    {
        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public String Province { get; set; }

        [DataMember]
        public string PostalCode { get; set; }
    }
}
