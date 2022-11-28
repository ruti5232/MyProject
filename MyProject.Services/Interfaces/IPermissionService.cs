using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IPermissionService
    {
        Task<List<PermissionDTO>>GetListAsync();

        Task<PermissionDTO> GetByIdAsync(int id);

        public Task<PermissionDTO> AddAsync(int id, string name, string description);

        public Task<PermissionDTO> UpdateAsync(PermissionDTO roleDTO);

        public Task DeleteAsync(int id);

    }
}
