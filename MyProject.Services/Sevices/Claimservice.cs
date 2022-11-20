using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Claim = MyProject.Repositories.Entities.Claim;
namespace MyProject.Services.Sevices
{
    public class Claimservice : IClaimService
    {
        private readonly IClaimRepository _claimRepository;

        private readonly IMapper _mapper;
        public Claimservice(IClaimRepository claimRepository,IMapper mapper)
        {
            _claimRepository = claimRepository;
            _mapper = mapper;
        }

        public ClaimDTO Add(int id, int roleId, int permissionId, Common.DTOs.EPolicy policy)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.Add(id,roleId,permissionId,policy));
        }

        public void Delete(int id)
        {
            _claimRepository.Delete(id);
        }

        public ClaimDTO GetById(int id)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.GetById(id));
        }

        public List<ClaimDTO> GetList()
        {
            return _mapper.Map<List<ClaimDTO>>(_claimRepository.GetAll());
        }

        public ClaimDTO Update(Claim claim)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.Update(claim));
        }
    }
}
