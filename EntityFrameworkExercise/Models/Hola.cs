using System;
using System.Collections.Generic;

namespace EntityFrameworkExercise.Models
{
    public partial class Hola
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public decimal Salary { get; set; }
    }
}
