using System.ComponentModel.DataAnnotations;

namespace BEU_ODEV_3.Models
{
    public class UserType
    {
        [Key]
        public int Id { get; set; } 
        [Required]  
        public string Name { get; set; }    
    }
}
