using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppVeterinary.Interfaces;

namespace WebAppVeterinary.Models
{
    public partial class Client : IEntity
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
    [MetadataType(typeof(ClientMetadata))]
    public partial class Client
    {
        public class ClientMetadata
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
            [StringLength(100), Required, Index(IsUnique = true)]
            public string Email { get; set; }
        }
    }
}