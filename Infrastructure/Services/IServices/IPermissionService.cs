using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.IServices
{
    public interface IPermissionService
    {
        Task<IEnumerable<Permission>> GetPermissionsByRole(int roleId);
        Task<IEnumerable<Permission>> GetAllPermissions();

    }
}