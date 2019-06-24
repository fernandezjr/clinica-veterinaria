using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVeterinary.Interfaces;

namespace WebAppVeterinary.Models
{
    public partial class RoomType : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int BedsNumber { get; set; }
    }
    [MetadataType(typeof(RoomTypeMetadata))]
    public partial class RoomType
    {
        public class RoomTypeMetadata
        {
            public int Id { get; set; }
            [StringLength(50), Required, Index(IsUnique = true)]
            public string Description { get; set; }
            [Required]
            public int BedsNumber { get; set; }
        }
    }
}