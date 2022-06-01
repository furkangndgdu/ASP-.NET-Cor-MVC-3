using System.ComponentModel.DataAnnotations;

namespace BEU_ODEV_3.Models
{
    public class CourseUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; } 
        public double Score { get; set; }   
    }
}
