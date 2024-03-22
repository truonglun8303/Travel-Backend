using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace do_an_Travel_Backend.Models.EF
{
    [Table("tb_DestinationImage")]
    public class DestinationImage
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int DestinationId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDefault { get; set; }

        public virtual Destination Destination { get; set; }
    }
}
