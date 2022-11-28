using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;

namespace MyProject.Services.Interfaces
{
    public interface IRoleService
    {
        Task<List<RoleDTO>> GetListAsync();

        Task<RoleDTO> GetByIdAsync(int id);

        public Task<RoleDTO> AddAsync(int id, string name, string description);

        public Task<RoleDTO> UpdateAsync(RoleDTO roleDTO);

        public Task DeleteAsync(int id);

    }
}
