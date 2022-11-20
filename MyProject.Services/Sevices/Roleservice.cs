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
        public RoleDTO Add(int id, string name, string description)
        {
            return _mapper.Map<RoleDTO>(_roleRepository.Add(id, name, description));
        }

        public void Delete(int id)
        {
          _roleRepository.Delete(id);
        }

        public RoleDTO GetById(int id)
        {
            return _mapper.Map<RoleDTO>(_roleRepository.GetById(id));
        }

        public List<RoleDTO> GetList()
        {
            return _mapper.Map<List<RoleDTO>>(_roleRepository.GetAll());
        }

        public RoleDTO Update(RoleDTO roleDTO)
        {
            return _mapper.Map<RoleDTO>(_roleRepository.Update(_mapper.Map<Role>(roleDTO)));
        }

    }
}
