using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppVeterinary.Models
{
    public partial class PatientRecoveryRoom
    {
        public RecoveryRoom RecoveryRoom { get; set; }
        public int RecoveryRoomId { get; set; }
        public int BedNumber { get; set; }
        public Patient Patient { get; set; }
        public int PatientId { get; set; }
        public DateTime InDate { get; set; }
        public DateTime OutDate { get; set; }
    }
    [MetadataType(typeof(PatientRecoveryRoomMetadata))]
    public partial class PatientRecoveryRoom
    {
        public class PatientRecoveryRoomMetadata
        {
            [Key, ForeignKey("RecoveryRoom"), Column(Order = 1)]
            public int RecoveryRoomId { get; set; }
            [Key, ForeignKey("RecoveryRoom"), Column(Order = 2)]
            public int BedNumber { get; set; }
            [Key, ForeignKey("Patient"), Column(Order = 3)]
            public int PatientId { get; set; }
            [Key, Column(Order = 4)]
            public DateTime InDate { get; set; }
            public DateTime OutDate { get; set; }
        }
    }
}