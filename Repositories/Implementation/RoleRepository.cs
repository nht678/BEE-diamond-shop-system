﻿using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation;

public class RoleRepository(RoleDao roleDao) : IRoleRepository
{
    public RoleDao RoleDao { get; } = roleDao;

    public async Task<IEnumerable<Role?>?> Gets()
    {
        return await RoleDao.GetRoles();
    }

    public async Task<Role?> GetById(int id)
    {
        return await RoleDao.GetRoleById(id);
    }

    public async Task<int> Create(Role entity)
    {
        return await RoleDao.CreateRole(entity);
    }
}