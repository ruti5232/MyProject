using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {

        private readonly IRoleRepository _roleRepository;

        public RolesController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpGet]

        public async Task<List<Role>> Get()
        {
            return await _roleRepository.GetAllAsync();
        }

        [HttpGet("{id}")]

        public async Task<Role> Get(int id)
        {
            return await _roleRepository.GetByIdAsync(id);
        }

        [HttpDelete("{id}")]

        public async Task Delete(int id)
        {
            await _roleRepository.DeleteAsync(id);
        }

        [HttpPut]
        public async Task Put([FromBody] Role role)
        {
            //var roleTask1 = _roleRepository.UpdateAsync(role);
            //return await _roleRepository.UpdateAsync(role);
             await _roleRepository.UpdateAsync(role);
        }

        [HttpPost]
        public async Task<Role> Post([FromBody] Role role)
        {
            //var roleTask1 = _roleRepository.AddAsync(role.Id,role.Name,role.Description);
            //await roleTask1 ;
            //return roleTask1.Result;
            return await _roleRepository.AddAsync(role.Id, role.Name, role.Description);

        }


    }
}
