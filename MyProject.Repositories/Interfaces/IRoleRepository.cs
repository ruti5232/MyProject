using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        public Task<List<Role>> GetAllAsync();

        public Task<Role> GetByIdAsync(int id);

        public Task<Role> AddAsync(int id, string name, string description);

        public Task<Role> UpdateAsync(Role role);

        public Task DeleteAsync(int id);

    }
}
