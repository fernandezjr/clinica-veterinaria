using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppVeterinary.Interfaces;

namespace WebAppVeterinary.Models
{
    public partial class DoctorEspeciality : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
    [MetadataType(typeof(DoctorEspecialityMetadata))]
    public partial class DoctorEspeciality
    {
        public class DoctorEspecialityMetadata
        {
            public int Id { get; set; }
            [StringLength(50), Required, Index(IsUnique = true)]
            public string Description { get; set; }
        }
    }
}