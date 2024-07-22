using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.IRepository
{
    public interface IPermissionRepository
    {
        Task<IEnumerable<Permission>> GetPermissionsByRole(long roleId);
        Task<IEnumerable<Permission>> GetAllPermissions();
    }
}