namespace IronSwords.WebApi.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsHost { get; set; } = false;
    }
}
