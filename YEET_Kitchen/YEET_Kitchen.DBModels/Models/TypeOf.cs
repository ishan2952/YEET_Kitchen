using System.ComponentModel.DataAnnotations;

namespace YEET_Kitchen.DBModels.Models
{
    public class TypeOf : EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}