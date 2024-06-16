﻿using BusinessObjects.Context;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;
using Tools;

namespace DAO;

public class RoleDao
{
    private readonly JssatsContext _context;
    public RoleDao()
    {
        _context = new JssatsContext();
    }
    public async Task<Role?> GetRoleById(string id)
    {
        return await _context.Roles.FirstOrDefaultAsync(r=>r.RoleId == id);
    }
    public async Task<IEnumerable<Role?>?> GetRoles()
    {
        return await _context.Roles.ToListAsync();
    }
    public async Task<int> CreateRole(Role role)
    {
        role.RoleId = IdGenerator.GenerateId();
        _context.Roles.Add(role);
        return await _context.SaveChangesAsync();
    }
}