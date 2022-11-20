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
        List<RoleDTO> GetList();

        RoleDTO GetById(int id);

        public RoleDTO Add(int id, string name, string description);

        public RoleDTO Update(Role roleDTO);

        public void Delete(int id);

    }
}
