using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppVeterinary.Models
{
    public partial class RecoveryRoom
    {
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public int BedNumber { get; set; }
    }
    [MetadataType(typeof(RecoveryRoomMetadata))]
    public partial class RecoveryRoom
    {
        public class RecoveryRoomMetadata
        {
            [Key, ForeignKey("Room"), Column(Order = 1)]
            public int RoomId { get; set; }
            [Key, Column(Order = 2)]            
            public int BedNumber { get; set; }
        }
    }
}