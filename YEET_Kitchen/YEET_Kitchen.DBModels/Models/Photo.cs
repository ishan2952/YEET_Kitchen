using System.ComponentModel.DataAnnotations;

namespace YEET_Kitchen.DBModels.Models
{
    public class Photo
    {
        [Required]
        public string URL { get; set; }
    }
}