using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCodeFirstApproach.Models
{
    public partial class Activity
    {
        public int ActivityId { get; set; }

        public ActivitiesEnum ActivityName { get; set; }

        public int Points { get; set; }


    }
}
