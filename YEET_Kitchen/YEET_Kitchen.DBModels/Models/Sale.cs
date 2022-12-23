using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YEET_Kitchen.DBModels.Models
{
    public class Sale: EntityBase
    {
        [Required]
        public int Qty { get; set; }

        [Required]
        [ForeignKey("Dish")]
        public Guid DishId{ get; set; }
        public virtual Dish Dish { get; set; }

    }
}
