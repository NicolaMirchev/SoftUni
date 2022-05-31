using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCodeFirstApproach.Models
{
    public partial class Person
    {
        public Person()
        {
            Activity = new HashSet<Activity>();
            FriendsRelations = new HashSet<FriendRelation>();
        }

        [Key]
        public int PersonId { get; set; }
        [Required]
        public string Name { get; set; } = null!;


        public ICollection<FriendRelation> FriendsRelations { get; set; }

        public ICollection<Activity> Activity { get; set; }

        [NotMapped]
        public bool HasBeenPassed { get; set; }

    }
}
