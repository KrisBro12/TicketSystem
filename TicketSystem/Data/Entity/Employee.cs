using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketSystem.Data.Entity
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public string lastname { get; set; }

        //FK to department id
        [ForeignKey(nameof(department))]
        public int departmentId { get; set; }

        public Department department { get; set; }

        public string skills { get; set; }


    }
}
