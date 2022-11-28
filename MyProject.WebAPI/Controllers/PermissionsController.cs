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
    public class PermissionsController : ControllerBase
    {

        private readonly IPermissionRepository _permissionRepository;

        public PermissionsController(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        [HttpGet]

        public async Task<List<Permission>> Get()
        {
            return await _permissionRepository.GetAllAsync();
        }

        [HttpGet("{id}")]

        public async Task<Permission> Get(int id)
        {
            return await _permissionRepository.GetByIdAsync(id);
        }

        [HttpDelete("{id}")]

        public async Task Delete(int id)
        {
            await _permissionRepository.DeleteAsync(id);
        }

        [HttpPut]
        public async Task Put([FromBody] Permission permission)
        {
            //var permissionTask1 = _permissionRepository.UpdateAsync(permission);
            //return await _permissionRepository.UpdateAsync(permission);
            await _permissionRepository.UpdateAsync(permission);
        }

        //[HttpPost]
        //public async Task<Permission> Post([FromBody] Permission permission)
        //{
        //    //var permissionTask1 = _permissionRepository.AddAsync(permission.Id, permission.Name, permission.Description);
        //    //await permissionTask1;
        //    //return permissionTask1.Result;
        //    return await _permissionRepository.AddAsync(permission.Id, permission.Name, permission.Description);

        //}
    }
}
