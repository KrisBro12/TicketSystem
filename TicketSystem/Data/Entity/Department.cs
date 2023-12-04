using System.ComponentModel.DataAnnotations;
namespace TicketSystem.Data.Entity
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }



    }
}
