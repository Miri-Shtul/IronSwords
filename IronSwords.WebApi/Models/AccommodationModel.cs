using IronSwords.Repositories.Entities;

namespace IronSwords.WebApi.Models
{
    public class AccommodationModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int HostId { get; set; }
        public User Host { get; set; }
        public string Location { get; set; }
        public int Size { get; set; }
        public int NumberOfBeds { get; set; }
        public string Photos { get; set; }
        public bool IsAvailable { get; set; }
    }
}
