using System;
using System.Collections.Generic;

namespace EntityFrameworkExercise.Models
{
    public partial class Cte2
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = null!;
        public string ProjectName { get; set; } = null!;
        public int ProjectId { get; set; }
        public DateTime StartDate { get; set; }
    }
}
