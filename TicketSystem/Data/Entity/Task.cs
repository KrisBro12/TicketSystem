using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketSystem.Data.Entity
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        //FK to employee id
        [ForeignKey(nameof(employee))]
        public int employeeId { get; set; }

        public Employee employee{ get; set; }

        public DateTime created_date { get; set; }


    }
}
