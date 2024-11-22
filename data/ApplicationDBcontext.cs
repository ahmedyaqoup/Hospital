using Hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.data
{
    public class ApplicationDBcontext :DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Hospital509;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>()
                .HasData(new Doctor()
                {
                    Id = 1,
                    Name = "Dr. John Smith",
                    Specialization = "Cardiology",
                    Img = "doctor1.jpg"
                });

            modelBuilder.Entity<Doctor>()
                .HasData(new Doctor()
                {
                    Id = 2,
                    Name = "Dr. Sarah Johnson",
                    Specialization = "Pediatrics",
                    Img = "doctor3.jpg"
                });

            modelBuilder.Entity<Doctor>()
                .HasData(new Doctor()
                {
                    Id = 3,
                    Name = "Dr. Emily Davis",
                    Specialization = "Dermatology",
                    Img = "doctor5.jpg"
                });

            modelBuilder.Entity<Doctor>()
                .HasData(new Doctor()
                {
                    Id = 4,
                    Name = "Dr. Michael Lee",
                    Specialization = "Orthopedics",
                    Img = "doctor2.jpg"
                });

            modelBuilder.Entity<Doctor>()
                .HasData(new Doctor()
                {
                    Id = 5,
                    Name = "Dr. William Clark",
                    Specialization = "Neurology",
                    Img = "doctor6.jpg"
                });

            modelBuilder.Entity<Doctor>()
                .HasData(new Doctor()
                {
                    Id = 6,
                    Name = "Dr. Younis Musa",
                    Specialization = "Cardiac surgery",
                    Img = "doctor4.jpg"
                });


        }
    }
}
