using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCodeFirstApproach.Models
{
    public class User
    {
        public User()
        {
            SoldProducts = new HashSet<Product>();
            BoughtProducts = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; } = null!;
        [JsonProperty("last_name")]
        public string LastName { get; set; } = null!;
        [JsonProperty("age")]
        public int Age { get; set; }

        public ICollection<Product> SoldProducts { get; set; }

        public ICollection<Product> BoughtProducts { get; set; } 
    }
}
