using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IPermissionRepository
    {
        public Task<List<Permission>> GetAllAsync();

        public Task<Permission> GetByIdAsync(int id);

        public Task<Permission> AddAsync(int id, string name, string description);

        public Task<Permission> UpdateAsync(Permission permission);

        public Task DeleteAsync(int id);

    }
}
