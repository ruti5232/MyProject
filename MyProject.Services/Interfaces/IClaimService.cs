using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IClaimService
    {
        public List<ClaimDTO> GetList();

        public ClaimDTO GetById(int id);

        public ClaimDTO Add(int id, int roleId, int permissionId, EPolicy policy);

        public ClaimDTO Update(Claim claim);

        public void Delete(int id);
    }
}
