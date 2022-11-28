using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        public Task<List<Claim>> GetAllAsync();

        public Task<Claim> GetByIdAsync(int id);

        public Task<Claim> AddAsync(int id, int roleId, int permissionId, EPolicy policy);

        public Task<Claim> UpdateAsync(Claim claim);

        public Task DeleteAsync(int id);

    }
}
