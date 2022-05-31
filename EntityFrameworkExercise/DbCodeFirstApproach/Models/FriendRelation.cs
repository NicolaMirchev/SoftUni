using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCodeFirstApproach.Models
{
    public partial class FriendRelation
    {

        public FriendRelation()
        {
            Friends = new HashSet<Person>();
        }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;

        public ICollection<Person> Friends { get; set; }


    }
}
