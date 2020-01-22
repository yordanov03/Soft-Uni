using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data.Models;
using P01_HospitalDatabase;

namespace P01_HospitalDatabase.Data 
{
    public class HospitalDBContext:DbContext
    {
        public HospitalDBContext()
        {

        }

        public HospitalDBContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientMedicament> Perscriptions { get; set; }
        public DbSet<Visitation> Visitations { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.PatientID);

                entity.Property(e => e.FirstName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

                entity.Property(e => e.LastName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

                entity.Property(e => e.Address)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(250);

                entity.Property(e => e.Address)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(80);

                entity.Property(e => e.HasInsurance)
                .HasDefaultValue(true);
            });


            modelBuilder.Entity<Visitation>(
                entity =>
                {
                    entity.HasKey(e => e.VisitationId);

                    entity.Property(e => e.Date)
                    .HasColumnType("DATETIME2")
                    .HasDefaultValueSql("GETDATE()")
                    .IsRequired();

                    entity.Property(e => e.Comments)
                    .IsRequired(false)
                    .HasMaxLength(250).
                    IsUnicode();

                    entity.HasOne(e => e.Patient)
                    .WithMany(p => p.Visitations)
                    .HasForeignKey(p => p.PatientID)
                    .HasConstraintName("FK_Visitation_Patient");
                });

            modelBuilder.Entity<Diagnose>(
                entity =>
                {
                    entity.HasKey(d => d.DiagnoseId);

                    entity.Property(d => d.Name)
                    .IsRequired()
                    .IsUnicode()
                    .HasMaxLength(50);

                    entity.Property(d => d.Comments)
                    .IsRequired(false)
                    .IsUnicode()
                    .HasMaxLength(250);

                    entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Diagnoses)
                    .HasForeignKey(p => p.PatientID)
                    .HasConstraintName("FK_Diagnoses_Patients");
                });

            modelBuilder.Entity<Medicament>(
                entity =>
                {
                    entity.HasKey(m => m.MedicamentID);

                    entity.Property(m => m.Name)
                    .IsUnicode()
                    .HasMaxLength(50)
                    .IsRequired();

                });

            modelBuilder.Entity<PatientMedicament>(
                entity =>
                {
                    entity.HasKey(pm => new { pm.PatientID, pm.MedicamentID });

                    entity.HasOne(e => e.Patient)
                        .WithMany(p => p.Perscriptions)
                        .HasForeignKey(e => e.PatientID);

                    entity.HasOne(e => e.Medicament)
                        .WithMany(m => m.Perscriptions)
                        .HasForeignKey(e => e.MedicamentID);
                });

            modelBuilder.Entity<Doctor>(entity =>
            {

                entity.HasKey(e => e.DoctorId);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode()
                    .IsRequired();

                entity.Property(e => e.Specialty)
                    .HasMaxLength(100)
                    .IsUnicode()
                    .IsRequired();

                entity.HasMany(x => x.Visitations).WithOne(x => x.Doctor).HasForeignKey(x => x.DoctorID);

            });
        }
    }
}
