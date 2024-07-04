using BusinessObjects.Context;
using BusinessObjects.Models;
using Domain.Constants;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class UserDao
    {
        private readonly JssatsContext _context;

        public UserDao()
        {
            _context = new JssatsContext();
        }
        public async Task<User?> GetUser(string email, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(p => p.Email == email && p.Password == password);
        }

        /// <summary>
        /// Lấy ra nhân viên không có counter
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<User?>?> GetStaffHasNoCounter()
        {
            return await _context.Users.Where(x => x.RoleId == (int)AppRole.Staff && x.CounterId == null).ToListAsync();
        }

        /// <summary>
        /// Lấy ra nhân viên theo counter
        /// </summary>
        /// <param name="counterId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<User?>?> GetStaffCounter(int counterId)
        {
            return await _context.Users.Where(x => x.RoleId == (int)AppRole.Staff && x.CounterId == counterId).ToListAsync();
        }
        public async Task<IEnumerable<User?>?> GetUsers(int? roleId)
        {
            if (roleId != null)
            {
                return await _context.Users.Include(x => x.Counter).Where(x => x.RoleId == roleId).ToListAsync();
            }
            else
            {
                return await _context.Users.Include(x => x.Counter).ToListAsync();
            }
        }
        public async Task<int> AddUser(User user)
        {
            _context.Users.Add(user);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateUser(int id, User user)
        {
            var existUser = await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);
            if (existUser == null) return 0;
            user.UserId = id;
            _context.Entry(existUser).CurrentValues.SetValues(user);
            _context.Entry(existUser).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
        public async Task<User?> GetUserById(int id)
        {
            return await _context.Users.FindAsync(id);
        }
        public async Task<int> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return 0;
            _context.Users.Remove(user);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                return 0;
            }
            return 1;
        }
    }
}
