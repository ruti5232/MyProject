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
        public List<ClaimDTO> GetList();

        public ClaimDTO GetById(int id);

        public ClaimDTO Add(int id, int roleId, int permissionId, EPolicy policy);

        public ClaimDTO Update(ClaimDTO claim);

        public void Delete(int id);
    }
}
