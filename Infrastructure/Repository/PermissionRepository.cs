using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly DBContext _dbContext;

        public PermissionRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Permission>> GetPermissionsByRole(long roleId)
        {
            return await _dbContext.RolesPermissions
                .Where(rp => rp.RoleId == roleId)
                .Select(rp => rp.Permission)
                .ToListAsync();
        }

        public async Task<IEnumerable<Permission>> GetAllPermissions()
        {
            return await _dbContext.Permission.ToListAsync();
        }
    }
}
