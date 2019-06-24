using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppVeterinary.Interfaces;

namespace WebAppVeterinary.Models
{
    public partial class Doctor : IEntity
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DoctorEspeciality Especiality { get; set; }
        public int DoctorEspecialityId { get; set; }
    }
    [MetadataType(typeof(DoctorMetadata))]
    public partial class Doctor
    {
        public class DoctorMetadata
        {
            public int Id { get; set; }
            [Required, Index(IsUnique = true)]
            public int Dni { get; set; }
            [StringLength(50), Required]            
            public string Name { get; set; }
            [StringLength(50), Required]
            public string Surname { get; set; }
            [StringLength(10), Required, Index(IsUnique = true)]
            public string Phone { get; set; }
            public int DoctorEspecialityId { get; set; }
        }
    }
}