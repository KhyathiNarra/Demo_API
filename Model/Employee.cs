using System.ComponentModel.DataAnnotations;

namespace Demo_API.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }  //nullable property
        public string? Designation { get; set; }
        [DataType(DataType.Date)]
        public DateTime? JoinDate { get; set; }
    }
}
