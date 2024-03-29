using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApi.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        [JsonIgnore]
        public string PasswordHash { get; set; }
        public ICollection<Role> Roles { get; set; }

        public ICollection<Location> Locations { get; set; }
        public ICollection<Maintenance> Maintenances { get; set; }


    }
}