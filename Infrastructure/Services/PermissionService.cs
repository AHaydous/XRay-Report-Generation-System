using Domain.Models;
using Infrastructure.Repository.IRepository;
using Infrastructure.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;

        public PermissionService(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        public async Task<IEnumerable<Permission>> GetAllPermissions()
        {
            try
            {
                return await _permissionRepository.GetAllPermissions();
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                throw new Exception("Failed to retrieve permissions: " + ex.Message);
            }
        }


        public async Task<IEnumerable<Permission>> GetPermissionsByRole(int roleId)
        {
            try
            {
                return await _permissionRepository.GetPermissionsByRole(roleId);
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                throw new Exception($"Failed to retrieve permissions for role ID {roleId}: " + ex.Message);
            }
        }
    }
}