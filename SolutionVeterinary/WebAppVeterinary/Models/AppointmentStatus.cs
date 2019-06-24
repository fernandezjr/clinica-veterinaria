using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppVeterinary.Interfaces;

namespace WebAppVeterinary.Models
{
    public partial class AppointmentStatus : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
    [MetadataType(typeof(AppointmentStatusMetadata))]
    public partial class AppointmentStatus
    {
        public class AppointmentStatusMetadata
        {
            public int Id { get; set; }
            [StringLength(50), Required, Index(IsUnique = true)]
            public string Description { get; set; }
        }
    }
}