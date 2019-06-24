using System.ComponentModel.DataAnnotations;
using WebAppVeterinary.Interfaces;

namespace WebAppVeterinary.Models
{
    public partial class Patient : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PatientSpecies Species { get; set; }
        public int SpeciesId { get; set; }
        public string Gender { get; set; }
        public bool Castrated { get; set; }
        public Client Owner { get; set; }
        public int ClientID { get; set; }
    }

    [MetadataType(typeof(PatientMetadata))]
    public partial class Patient
    {
        public class PatientMetadata
        {
            public int Id { get; set; }
            [StringLength(50), Required]
            public string Name { get; set; }
            public int SpeciesId { get; set; }
            [Required]
            public bool Castrated { get; set; }
            [StringLength(50), Required]
            public string Gender { get; set; }
            public int ClientID { get; set; }
        }
    }
}