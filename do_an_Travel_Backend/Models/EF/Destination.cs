using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace do_an_Travel_Backend.Models.EF
{
    [Table("tb_Destination")]
    public class Destination
    {
        public Destination() 
        { 
            this.DestinationImages = new HashSet<DestinationImage>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        // Other properties as needed
        public virtual ICollection<DestinationImage> DestinationImages { get; set; }
        public virtual Category Category { get; set; }

    }
}
