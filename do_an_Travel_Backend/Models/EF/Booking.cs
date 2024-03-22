using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace do_an_Travel_Backend.Models.EF
{
    [Table("tb_Booking")]
    public class Booking
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int TourId { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime BookingDate { get; set; }
        public decimal TotalPrice { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

    }
}
