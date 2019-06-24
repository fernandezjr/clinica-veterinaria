namespace WebAppVeterinary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        RoomID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Time = c.Time(nullable: false, precision: 7),
                        PatientID = c.Int(nullable: false),
                        DoctorID = c.Int(nullable: false),
                        VisitID = c.Int(nullable: false),
                        AppointmentStatusId = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.RoomID, t.Date, t.Time })
                .ForeignKey("dbo.Doctors", t => t.DoctorID, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomID, cascadeDelete: true)
                .ForeignKey("dbo.AppointmentStatus", t => t.AppointmentStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Visits", t => t.VisitID, cascadeDelete: true)
                .Index(t => t.RoomID)
                .Index(t => t.PatientID)
                .Index(t => t.DoctorID)
                .Index(t => t.VisitID)
                .Index(t => t.AppointmentStatusId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dni = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 10),
                        DoctorEspecialityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DoctorEspecialities", t => t.DoctorEspecialityId, cascadeDelete: true)
                .Index(t => t.Dni, unique: true)
                .Index(t => t.Phone, unique: true)
                .Index(t => t.DoctorEspecialityId);
            
            CreateTable(
                "dbo.DoctorEspecialities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Description, unique: true);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        SpeciesId = c.Int(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 50),
                        Castrated = c.Boolean(nullable: false),
                        ClientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true)
                .ForeignKey("dbo.PatientSpecies", t => t.SpeciesId, cascadeDelete: true)
                .Index(t => t.SpeciesId)
                .Index(t => t.ClientID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dni = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 10),
                        Email = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Dni, unique: true)
                .Index(t => t.Phone, unique: true)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.PatientSpecies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Description, unique: true);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoomTypes", t => t.RoomTypeId, cascadeDelete: true)
                .Index(t => t.RoomTypeId);
            
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                        BedsNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Description, unique: true);
            
            CreateTable(
                "dbo.AppointmentStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Description, unique: true);
            
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 50),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Type, unique: true);
            
            CreateTable(
                "dbo.PatientRecoveryRooms",
                c => new
                    {
                        RecoveryRoomId = c.Int(nullable: false),
                        BedNumber = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        InDate = c.DateTime(nullable: false),
                        OutDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.RecoveryRoomId, t.BedNumber, t.PatientId, t.InDate })
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .ForeignKey("dbo.RecoveryRooms", t => new { t.RecoveryRoomId, t.BedNumber }, cascadeDelete: true)
                .Index(t => new { t.RecoveryRoomId, t.BedNumber })
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.RecoveryRooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false),
                        BedNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoomId, t.BedNumber })
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientRecoveryRooms", new[] { "RecoveryRoomId", "BedNumber" }, "dbo.RecoveryRooms");
            DropForeignKey("dbo.RecoveryRooms", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.PatientRecoveryRooms", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "VisitID", "dbo.Visits");
            DropForeignKey("dbo.Appointments", "AppointmentStatusId", "dbo.AppointmentStatus");
            DropForeignKey("dbo.Appointments", "RoomID", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "RoomTypeId", "dbo.RoomTypes");
            DropForeignKey("dbo.Appointments", "PatientID", "dbo.Patients");
            DropForeignKey("dbo.Patients", "SpeciesId", "dbo.PatientSpecies");
            DropForeignKey("dbo.Patients", "ClientID", "dbo.Clients");
            DropForeignKey("dbo.Appointments", "DoctorID", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "DoctorEspecialityId", "dbo.DoctorEspecialities");
            DropIndex("dbo.RecoveryRooms", new[] { "RoomId" });
            DropIndex("dbo.PatientRecoveryRooms", new[] { "PatientId" });
            DropIndex("dbo.PatientRecoveryRooms", new[] { "RecoveryRoomId", "BedNumber" });
            DropIndex("dbo.Visits", new[] { "Type" });
            DropIndex("dbo.AppointmentStatus", new[] { "Description" });
            DropIndex("dbo.RoomTypes", new[] { "Description" });
            DropIndex("dbo.Rooms", new[] { "RoomTypeId" });
            DropIndex("dbo.PatientSpecies", new[] { "Description" });
            DropIndex("dbo.Clients", new[] { "Email" });
            DropIndex("dbo.Clients", new[] { "Phone" });
            DropIndex("dbo.Clients", new[] { "Dni" });
            DropIndex("dbo.Patients", new[] { "ClientID" });
            DropIndex("dbo.Patients", new[] { "SpeciesId" });
            DropIndex("dbo.DoctorEspecialities", new[] { "Description" });
            DropIndex("dbo.Doctors", new[] { "DoctorEspecialityId" });
            DropIndex("dbo.Doctors", new[] { "Phone" });
            DropIndex("dbo.Doctors", new[] { "Dni" });
            DropIndex("dbo.Appointments", new[] { "AppointmentStatusId" });
            DropIndex("dbo.Appointments", new[] { "VisitID" });
            DropIndex("dbo.Appointments", new[] { "DoctorID" });
            DropIndex("dbo.Appointments", new[] { "PatientID" });
            DropIndex("dbo.Appointments", new[] { "RoomID" });
            DropTable("dbo.RecoveryRooms");
            DropTable("dbo.PatientRecoveryRooms");
            DropTable("dbo.Visits");
            DropTable("dbo.AppointmentStatus");
            DropTable("dbo.RoomTypes");
            DropTable("dbo.Rooms");
            DropTable("dbo.PatientSpecies");
            DropTable("dbo.Clients");
            DropTable("dbo.Patients");
            DropTable("dbo.DoctorEspecialities");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appointments");
        }
    }
}
