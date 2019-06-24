using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVeterinary.Interfaces;

namespace WebAppVeterinary.Models
{
    public partial class Room : IEntity
    {
        public int Id { get; set; }
        public RoomType Type { get; set; }
        public int RoomTypeId { get; set; }
    }

    [MetadataType(typeof(RoomMetadata))]
    public partial class Room
    {
        public class RoomMetadata
        {
            public int Id { get; set; }
            public int RoomTypeId { get; set; }
        }
    }
}