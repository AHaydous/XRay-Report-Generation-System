﻿using Infrastructure.Repository.IRepository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.UnitOfWork
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContext _context;

        public IUserRepository Users { get; }
        public IPermissionRepository Permissions { get; }
        public IRoleRepository Roles { get; }
        public IAppointmentRepository Appointments { get; }

        public UnitOfWork(DBContext dbContext,
            IUserRepository usersRepository,
            IPermissionRepository permissionRepository,
            IRoleRepository roleRepository,
            IAppointmentRepository appointmentRepository)
        {
            _context = dbContext;
            Users = usersRepository;
            Permissions = permissionRepository;
            Roles = roleRepository;
            Appointments = appointmentRepository;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}