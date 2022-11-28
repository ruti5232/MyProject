using AutoMapper;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;

namespace MyProject.Services.Sevices
{
    public class Roleservice:IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        public Roleservice(IRoleRepository roleRepository,IMapper mapper)
        {
             _roleRepository=roleRepository;
            _mapper = mapper;
        }
        public async Task<RoleDTO> AddAsync(int id, string name, string description)
        {
            return _mapper.Map<RoleDTO>(await _roleRepository.AddAsync(id,name,description));
        }

        public async Task DeleteAsync(int id)
        {
           await _roleRepository.DeleteAsync(id);
        }

        public async Task<RoleDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<RoleDTO>(await _roleRepository.GetByIdAsync(id));
        }

        public async Task<List<RoleDTO>> GetListAsync()
        {
            return _mapper.Map<List<RoleDTO>>(await _roleRepository.GetAllAsync());
        }

        public async Task<RoleDTO> UpdateAsync(RoleDTO roleDTO)
        {
            return _mapper.Map<RoleDTO>(await _roleRepository.UpdateAsync(_mapper.Map<Role>(roleDTO)));
        }

    }
}
