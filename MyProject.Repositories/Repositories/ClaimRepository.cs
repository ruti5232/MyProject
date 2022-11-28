using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly IContext _context;
        public ClaimRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Claim> AddAsync(int id,int roleId,int permissionId,EPolicy policy)
        {
            var added = _context.Claims.Add(new Claim { Id = id,RoleId=roleId,PermissionId=permissionId,Policy=policy });
            await _context.SaveChangesAsync();
            return added.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Claims.Remove(_context.Claims.Find(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Claim>> GetAllAsync()
        {
            return await _context.Claims.ToListAsync();
        }

        public async Task<Claim> GetByIdAsync(int id)
        {
            return await _context.Claims.FindAsync(id);
        }

        public async Task<Claim> UpdateAsync(Claim claim)
        {
            var c1 = _context.Claims.Find(claim.Id);
            c1.RoleId = claim.RoleId;
            c1.PermissionId = claim.PermissionId;
            c1.Policy = claim.Policy;
            await _context.SaveChangesAsync();
            return c1;
        }
    }
}
