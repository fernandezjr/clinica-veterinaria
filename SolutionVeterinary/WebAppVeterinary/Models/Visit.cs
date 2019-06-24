using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVeterinary.Interfaces;

namespace WebAppVeterinary.Models
{
    public partial class Visit : IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
    }
    [MetadataType(typeof(VisitMetadata))]
    public partial class Visit
    {
        public class VisitMetadata
        {
            public int Id { get; set; }
            [StringLength(50), Required, Index(IsUnique = true)]
            public string Type { get; set; }
            [Required]
            public double Price { get; set; }
        }
    }
}