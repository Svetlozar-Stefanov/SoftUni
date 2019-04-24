using System.ComponentModel.DataAnnotations;

namespace WildlifeRefuge.Models
{
    public class Animal
    {
        public int Id { get; set; }

        [Required]
        public string Kind { get; set; }
        
        [Required]
        public int ChipNumber { get; set; }

        [Required]
        public string Gender { get; set; }
    }
}
