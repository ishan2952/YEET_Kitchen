using System.ComponentModel.DataAnnotations;

namespace YEET_Kitchen.DBModels.Models
{
    public class EntityBase
    {
        public EntityBase()
        {
            CreatedDate = DateTime.Now; 
            UpdatedDate = DateTime.Now; 
            Active=true;
        }
        
        [Key]
        public Guid Id { get; set; }


       /// <summary>
       /// Soft delete
       /// </summary>
        public bool Active { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime UpdatedDate { get; set; }
    }
}
