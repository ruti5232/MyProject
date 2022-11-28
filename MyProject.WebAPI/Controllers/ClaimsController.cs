using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Security.Claims;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {

        private readonly IClaimRepository _claimRepository;

        public ClaimsController(IClaimRepository claimRepository)
        {
            _claimRepository =claimRepository;
        }

        [HttpGet]

        public async Task<List<Claim>> Get()
        {
            return await _claimRepository.GetAllAsync();
        }

        [HttpGet("{id}")]

        public async Task<Claim> Get(int id)
        {
            return await _claimRepository.GetByIdAsync(id);
        }

        [HttpDelete("{id}")]

        public async Task Delete(int id)
        {
            await _claimRepository.DeleteAsync(id);
        }

        [HttpPut]
        public async Task Put([FromBody] Claim claim)
        {
            //var claimTask1 = _claimRepository.UpdateAsync(claim);
            //return await _claimRepository.UpdateAsync(claim);
            await _claimRepository.UpdateAsync(claim);
        }

        //[HttpPost]
        //public async Task<Claim> Post([FromBody] Claim claim)
        //{
        //    //var claimTask1 = _claimRepository.AddAsync(claim.Id,claim.RoleId, claim.PermissionId,claim.Policy);
        //    //await claimTask1;
        //    //return claimTask1.Result;
        //    return await _claimRepository.AddAsync(claim.Id, claim.RoleId, claim.PermissionId, claim.Policy);

        //}

    }
}
