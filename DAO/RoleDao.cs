using BusinessObjects.Context;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO;

public class RoleDao
{
    private readonly JssatsContext _context;
    public RoleDao()
    {
        _context = new JssatsContext();
    }
    public async Task<Role?> GetRoleById(int id)
    {
        return await _context.Roles.FirstOrDefaultAsync(r => r.RoleId == id);
    }
    public async Task<IEnumerable<Role?>?> GetRoles()
    {
        return await _context.Roles.ToListAsync();
    }
    public async Task<int> CreateRole(Role role)
    {
        _context.Roles.Add(role);
        return await _context.SaveChangesAsync();
    }
}