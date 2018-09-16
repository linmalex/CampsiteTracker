namespace CampsiteTracker.Models
{
    public class Campsite
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string TentType { get; set; }
        public string VehicleAccess { get; set; }
        public string CampsiteType { get; set; }
        public string ToiletAccess { get; set; }
        public string DogFriendly { get; set; }
    }

   
}