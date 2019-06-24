using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppVeterinary.Models
{
    public partial class Appointment
    {
        public Patient Patient { get; set; }
        public int PatientID { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorID { get; set; }
        public Room Room { get; set; }
        public int RoomID { get; set; }
        public Visit Visit { get; set; }
        public int VisitID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public AppointmentStatus Status { get; set; }
        public int AppointmentStatusId { get; set; }
        public string Description { get; set; }
    }
    [MetadataType(typeof(AppointmentMetadata))]
    public partial class Appointment
    {
        public class AppointmentMetadata
        {
            public int PatientID { get; set; }
            public int DoctorID { get; set; }
            public int VisitID { get; set; }
            [Key, ForeignKey("Room"), Column(Order = 1)]
            public int RoomID { get; set; }                        
            [Key, Column(Order = 2)]
            public DateTime Date { get; set; }
            [Key, Column(Order = 3)]
            public TimeSpan Time { get; set; }
            [Required]
            public int AppointmentStatusId { get; set; }
            [StringLength(50), Required]
            public string Description { get; set; }
        }
    }
}