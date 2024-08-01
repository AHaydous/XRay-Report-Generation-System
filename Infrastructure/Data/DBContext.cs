﻿using Domain.Models;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppointmentConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RolePermissionConfiguration).Assembly);

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "Doctor" },
                new Role { Id = 3, Name = "Patient" }
            );

            modelBuilder.Entity<Permission>().HasData(
                new Permission { Id = 1, Name = "ManageUsers" },
                new Permission { Id = 2, Name = "ManageRoles" },
                new Permission { Id = 3, Name = "ViewAppointments" },
                new Permission { Id = 4, Name = "ViewPatientHistory" },
                new Permission { Id = 5, Name = "BookAppointments" },
                new Permission { Id = 6, Name = "DownloadReports" },
                new Permission { Id = 7, Name = "Signup" },
                new Permission { Id = 8, Name = "Login" },
                new Permission { Id = 9, Name = "UploadImage" }
            );

            modelBuilder.Entity<RolesPermissions>().HasData(
                new RolesPermissions { Id = 1, RoleId = 1, PermissionId = 1 },
                new RolesPermissions { Id = 2, RoleId = 1, PermissionId = 2 },
                new RolesPermissions { Id = 3, RoleId = 1, PermissionId = 8 },
                new RolesPermissions { Id = 4, RoleId = 2, PermissionId = 3 },
                new RolesPermissions { Id = 5, RoleId = 2, PermissionId = 4 },
                new RolesPermissions { Id = 6, RoleId = 2, PermissionId = 8 },
                new RolesPermissions { Id = 7, RoleId = 3, PermissionId = 5 },
                new RolesPermissions { Id = 8, RoleId = 3, PermissionId = 6 },
                new RolesPermissions { Id = 9, RoleId = 3, PermissionId = 7 },
                new RolesPermissions { Id = 10, RoleId = 3, PermissionId = 8 },
                new RolesPermissions { Id = 11, RoleId = 3, PermissionId = 9 }
             );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<RolesPermissions> RolesPermissions { get; set; }
        public DbSet<Appointment> Appointments { get; set; }


    }
}
