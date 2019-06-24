using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppVeterinary.Models;

namespace WebAppVeterinary.Data
{
    public class ClinicaDbContext : DbContext
    {
        public ClinicaDbContext() : base("ClinicaDbContext")
        {

        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientSpecies> PatientSpecies { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorEspeciality> DoctorEspecialities { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentStatus> AppointmentStatus { get; set; }
        public DbSet<RecoveryRoom> RecoveryRooms { get; set; }
        public DbSet<PatientRecoveryRoom> PatientRecoveryRooms { get; set; }
    }
}