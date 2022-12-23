using System.ComponentModel.DataAnnotations;

namespace YEET_Kitchen.DBModels.Models
{
    public class Menu :EntityBase
    {
        [Required]
        public string Name { get; set; }

        
        [Required]
        public virtual ICollection<Dish> Dishes { get; set; }
    }
}
