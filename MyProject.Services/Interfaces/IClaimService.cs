using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPolicy = MyProject.Common.DTOs.EPolicy;

namespace MyProject.Services.Interfaces
{
    public interface IClaimService
    {
        public Task<List<ClaimDTO>> GetListAsync();

        public Task<ClaimDTO> GetByIdAsync(int id);

        public Task<ClaimDTO> AddAsync(int id, int roleId, int permissionId, EPolicy policy);

        public Task<ClaimDTO> UpdateAsync(ClaimDTO claim);

        public Task DeleteAsync(int id);
    }
}
