
using System.ComponentModel.DataAnnotations;

namespace SideStep.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set;}
        [Required]
        [MaxLength(100)]
        public string Name { get; set;}
        
        public string Category { get; set;}
        
        public string Status { get; set;}
    }
}    
    

