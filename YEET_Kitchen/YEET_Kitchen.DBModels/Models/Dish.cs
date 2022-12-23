using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace YEET_Kitchen.DBModels.Models
{
    public class Dish : EntityBase
    {
        

        [Required]
        public string Name { get; set; }

        [Required]
        public long Price { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        
        public string CookingTime { get; set; }

        [Required]
        public long Calories { get; set; }

        [Required]
        public virtual ICollection<Ingredient> Ingredients { get; set; }

        [Required]
        [ForeignKey("TypeOf")]
        public Guid TypeOfId { get; set; }
        public virtual TypeOf TypeOf { get; set; }

        [Required]
        [ForeignKey("Photo")]
        public Guid PhotoId { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
