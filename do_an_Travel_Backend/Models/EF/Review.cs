using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace do_an_Travel_Backend.Models.EF
{
    [Table("tb_Review")]
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public int TourId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        // Other properties as needed
    }
}
