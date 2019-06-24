namespace WebAppVeterinary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppVeterinary.Data.ClinicaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAppVeterinary.Data.ClinicaDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Clients.AddOrUpdate(x => x.Id,
                new Models.Client() { Id = 1, Dni = 36534726, Name = "Roberto", Surname = "Mendez", Phone = "1165738211", Email = "roberto@gmail.com" },
                new Models.Client() { Id = 2, Dni = 28324116, Name = "Maria", Surname = "Cepeda", Phone = "1134347683", Email = "maria@hotmail.com" },
                new Models.Client() { Id = 3, Dni = 34361872, Name = "Marta", Surname = "Sanchez", Phone = "1156366443", Email = "marta@outlook.com" },
                new Models.Client() { Id = 4, Dni = 32467983, Name = "Diego", Surname = "Lopez", Phone = "1127638210", Email = "diego@gmail.com" },
                new Models.Client() { Id = 5, Dni = 36465823, Name = "Noelia", Surname = "Ramos", Phone = "1168701565", Email = "noelia@hotmail.com" },
                new Models.Client() { Id = 6, Dni = 29385383, Name = "Osvaldo", Surname = "Rueda", Phone = "1154537624", Email = "osvaldo@gmail.com" },
                new Models.Client() { Id = 7, Dni = 30116274, Name = "Sofia", Surname = "Mancilla", Phone = "1171963520", Email = "sofia@hotmail.com" },
                new Models.Client() { Id = 8, Dni = 33501623, Name = "Emilio", Surname = "Gomez", Phone = "1192642356", Email = "emilio@gmail.com" }
                );

            context.PatientSpecies.AddOrUpdate(x => x.Id,
                new Models.PatientSpecies() { Id = 1, Description = "Perro" },
                new Models.PatientSpecies() { Id = 2, Description = "Gato" }
                );

            context.Patients.AddOrUpdate(x => x.Id,
                new Models.Patient() { Id = 1, Name = "Tita", SpeciesId = 1, Gender = "Hembra", Castrated = false, ClientID = 1 },
                new Models.Patient() { Id = 2, Name = "Rocky", SpeciesId = 1, Gender = "Macho", Castrated = false, ClientID = 1 },
                new Models.Patient() { Id = 3, Name = "Mostaza", SpeciesId = 2, Gender = "Macho", Castrated = false, ClientID = 2 },
                new Models.Patient() { Id = 4, Name = "Bobi", SpeciesId = 1, Gender = "Macho", Castrated = false, ClientID = 2 },
                new Models.Patient() { Id = 5, Name = "Luna", SpeciesId = 2, Gender = "Hembra", Castrated = true, ClientID = 3 },
                new Models.Patient() { Id = 6, Name = "Rita", SpeciesId = 1, Gender = "Hembra", Castrated = true, ClientID = 4 },
                new Models.Patient() { Id = 7, Name = "Braulio", SpeciesId = 1, Gender = "Macho", Castrated = false, ClientID = 4 },
                new Models.Patient() { Id = 8, Name = "Sultan", SpeciesId = 1, Gender = "Macho", Castrated = false, ClientID = 5 },
                new Models.Patient() { Id = 9, Name = "Martina", SpeciesId = 2, Gender = "Hembra", Castrated = false, ClientID = 5 },
                new Models.Patient() { Id = 10, Name = "Rufus", SpeciesId = 1, Gender = "Macho", Castrated = false, ClientID = 5 },
                new Models.Patient() { Id = 11, Name = "Ambar", SpeciesId = 2, Gender = "Hembra", Castrated = false, ClientID = 6 },
                new Models.Patient() { Id = 12, Name = "Negro", SpeciesId = 2, Gender = "Macho", Castrated = false, ClientID = 6 },
                new Models.Patient() { Id = 13, Name = "Teo", SpeciesId = 1, Gender = "Macho", Castrated = false, ClientID = 7 },
                new Models.Patient() { Id = 14, Name = "Cleo", SpeciesId = 1, Gender = "Hembra", Castrated = true, ClientID = 8 },
                new Models.Patient() { Id = 15, Name = "Baltazar", SpeciesId = 1, Gender = "Macho", Castrated = false, ClientID = 8 }
                );

            context.DoctorEspecialities.AddOrUpdate(x => x.Id,
                new Models.DoctorEspeciality() { Id = 1, Description = "Clinica" },
                new Models.DoctorEspeciality() { Id = 2, Description = "Enfermeria" },
                new Models.DoctorEspeciality() { Id = 3, Description = "Cirujia" }
                );

            context.Doctors.AddOrUpdate(x => x.Id,
                new Models.Doctor() { Id = 1, Dni = 25364879, Name = "Analia", Surname = "Rios", Phone = "1197463732", DoctorEspecialityId = 2 },
                new Models.Doctor() { Id = 2, Dni = 21746112, Name = "Anibal", Surname = "Pereyra", Phone = "1149571762", DoctorEspecialityId = 3 },
                new Models.Doctor() { Id = 3, Dni = 22112579, Name = "Camila", Surname = "Alvarez", Phone = "1182364322", DoctorEspecialityId = 1 },
                new Models.Doctor() { Id = 4, Dni = 23684201, Name = "Marcos", Surname = "Sotelo", Phone = "1177226543", DoctorEspecialityId = 2 },
                new Models.Doctor() { Id = 5, Dni = 24845271, Name = "Alberto", Surname = "Montes", Phone = "1133648952", DoctorEspecialityId = 3 },
                new Models.Doctor() { Id = 6, Dni = 20603828, Name = "Norma", Surname = "Fuentes", Phone = "1193653564", DoctorEspecialityId = 1 }
                );

            context.RoomTypes.AddOrUpdate(x => x.Id,
                new Models.RoomType() { Id = 1, Description = "Examen", BedsNumber = 1 },
                new Models.RoomType() { Id = 2, Description = "Cirujia", BedsNumber = 1 },
                new Models.RoomType() { Id = 3, Description = "Recuperacion", BedsNumber = 3 }
                );

            context.Rooms.AddOrUpdate(x => x.Id,
                new Models.Room() { Id = 1, RoomTypeId = 1 },
                new Models.Room() { Id = 2, RoomTypeId = 1 },
                new Models.Room() { Id = 3, RoomTypeId = 1 },
                new Models.Room() { Id = 4, RoomTypeId = 1 },
                new Models.Room() { Id = 5, RoomTypeId = 2 },
                new Models.Room() { Id = 6, RoomTypeId = 1 },
                new Models.Room() { Id = 7, RoomTypeId = 1 },
                new Models.Room() { Id = 8, RoomTypeId = 1 },
                new Models.Room() { Id = 9, RoomTypeId = 3 },
                new Models.Room() { Id = 10, RoomTypeId = 3 }
                );

            context.Visits.AddOrUpdate(x => x.Id,
                new Models.Visit() { Id = 1, Type = "Examen", Price = 150 },
                new Models.Visit() { Id = 2, Type = "Vacuna", Price = 200 },
                new Models.Visit() { Id = 3, Type = "Castracion", Price = 300 },
                new Models.Visit() { Id = 4, Type = "Cirujia", Price = 500 }
                );

            context.AppointmentStatus.AddOrUpdate(x => x.Id,
                new Models.AppointmentStatus() { Id = 1, Description = "No Confirmado" },
                new Models.AppointmentStatus() { Id = 2, Description = "Confirmado" },
                new Models.AppointmentStatus() { Id = 3, Description = "Cancelado en Termino" },
                new Models.AppointmentStatus() { Id = 4, Description = "Cancelado Fuera de Termino" },
                new Models.AppointmentStatus() { Id = 5, Description = "Reprogramado por Cliente" },
                new Models.AppointmentStatus() { Id = 6, Description = "Reprogramado por Clinica" }
                );

            context.Appointments.AddOrUpdate(x => new { x.RoomID, x.Date, x.Time },
                new Models.Appointment() { PatientID = 1, DoctorID = 1, VisitID = 2, RoomID = 1, Date = new DateTime(2019, 6, 18), Time = new TimeSpan(10, 0, 0), AppointmentStatusId = 2, Description = "Parvovirus" },
                new Models.Appointment() { PatientID = 2, DoctorID = 1, VisitID = 2, RoomID = 1, Date = new DateTime(2019, 6, 18), Time = new TimeSpan(11, 0, 0), AppointmentStatusId = 3, Description = "Moquillo" },
                new Models.Appointment() { PatientID = 3, DoctorID = 2, VisitID = 4, RoomID = 5, Date = new DateTime(2019, 6, 18), Time = new TimeSpan(10, 0, 0), AppointmentStatusId = 2, Description = "Operacion en Pata" },
                new Models.Appointment() { PatientID = 4, DoctorID = 2, VisitID = 4, RoomID = 5, Date = new DateTime(2019, 6, 18), Time = new TimeSpan(11, 0, 0), AppointmentStatusId = 4, Description = "Operacion en Pata" },
                new Models.Appointment() { PatientID = 5, DoctorID = 2, VisitID = 3, RoomID = 5, Date = new DateTime(2019, 6, 19), Time = new TimeSpan(8, 0, 0), AppointmentStatusId = 2, Description = "Castracion" },
                new Models.Appointment() { PatientID = 6, DoctorID = 2, VisitID = 3, RoomID = 5, Date = new DateTime(2019, 6, 19), Time = new TimeSpan(10, 0, 0), AppointmentStatusId = 2, Description = "Castracion" },
                new Models.Appointment() { PatientID = 7, DoctorID = 4, VisitID = 2, RoomID = 2, Date = new DateTime(2019, 6, 21), Time = new TimeSpan(15, 0, 0), AppointmentStatusId = 3, Description = "Parvovirus" },
                new Models.Appointment() { PatientID = 8, DoctorID = 5, VisitID = 4, RoomID = 5, Date = new DateTime(2019, 6, 24), Time = new TimeSpan(9, 0, 0), AppointmentStatusId = 4, Description = "Operacion de Ojos" },
                new Models.Appointment() { PatientID = 9, DoctorID = 5, VisitID = 4, RoomID = 5, Date = new DateTime(2019, 6, 24), Time = new TimeSpan(13, 0, 0), AppointmentStatusId = 2, Description = "Operacion en Hosico" },
                new Models.Appointment() { PatientID = 10, DoctorID = 6, VisitID = 1, RoomID = 6, Date = new DateTime(2019, 6, 25), Time = new TimeSpan(14, 0, 0), AppointmentStatusId = 1, Description = "Examen por Vomitos" },
                new Models.Appointment() { PatientID = 11, DoctorID = 6, VisitID = 1, RoomID = 7, Date = new DateTime(2019, 6, 26), Time = new TimeSpan(10, 0, 0), AppointmentStatusId = 5, Description = "Examen por Latimadura" },
                new Models.Appointment() { PatientID = 12, DoctorID = 3, VisitID = 1, RoomID = 3, Date = new DateTime(2019, 6, 27), Time = new TimeSpan(12, 0, 0), AppointmentStatusId = 1, Description = "Examen por Vomitos" },
                new Models.Appointment() { PatientID = 13, DoctorID = 2, VisitID = 4, RoomID = 5, Date = new DateTime(2019, 6, 27), Time = new TimeSpan(8, 0, 0), AppointmentStatusId = 6, Description = "Operacion en Pata" },
                new Models.Appointment() { PatientID = 14, DoctorID = 6, VisitID = 1, RoomID = 8, Date = new DateTime(2019, 6, 28), Time = new TimeSpan(10, 0, 0), AppointmentStatusId = 1, Description = "Examen por Vomitos" },
                new Models.Appointment() { PatientID = 15, DoctorID = 5, VisitID = 4, RoomID = 5, Date = new DateTime(2019, 6, 29), Time = new TimeSpan(12, 0, 0), AppointmentStatusId = 1, Description = "Operacion en Pata" }
                );

            context.RecoveryRooms.AddOrUpdate(x => new { x.RoomId, x.BedNumber },
                new Models.RecoveryRoom() { RoomId = 9, BedNumber = 1 },
                new Models.RecoveryRoom() { RoomId = 9, BedNumber = 2 },
                new Models.RecoveryRoom() { RoomId = 9, BedNumber = 3 },
                new Models.RecoveryRoom() { RoomId = 10, BedNumber = 1 },
                new Models.RecoveryRoom() { RoomId = 10, BedNumber = 2 },
                new Models.RecoveryRoom() { RoomId = 10, BedNumber = 3 }
                );

            context.PatientRecoveryRooms.AddOrUpdate(x => new { x.RecoveryRoomId, x.BedNumber, x.PatientId, x.InDate },
                new Models.PatientRecoveryRoom() { RecoveryRoomId = 9, BedNumber = 1, PatientId = 3, InDate = new DateTime(2019, 6, 18), OutDate = new DateTime(2019, 6, 21) },
                new Models.PatientRecoveryRoom() { RecoveryRoomId = 9, BedNumber = 2, PatientId = 4, InDate = new DateTime(2019, 6, 18), OutDate = new DateTime(2019, 6, 21) },
                new Models.PatientRecoveryRoom() { RecoveryRoomId = 9, BedNumber = 1, PatientId = 9, InDate = new DateTime(2019, 6, 24), OutDate = new DateTime(2019, 6, 26) },
                new Models.PatientRecoveryRoom() { RecoveryRoomId = 10, BedNumber = 1, PatientId = 13, InDate = new DateTime(2019, 6, 27), OutDate = new DateTime(2019, 6, 29) },
                new Models.PatientRecoveryRoom() { RecoveryRoomId = 10, BedNumber = 2, PatientId = 15, InDate = new DateTime(2019, 6, 29), OutDate = new DateTime(2019, 7, 1) }
                );
        }
    }
}
