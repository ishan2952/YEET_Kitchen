using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YEET_Kitchen.DBModels.Models
{
    public class Ingredient : EntityBase
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public long Price { get; set; }

        [Required]
        [ForeignKey("TypeOf")]
        public Guid TypeOfId { get; set; }
        public virtual TypeOf TypeOf { get; set; }
    }
}