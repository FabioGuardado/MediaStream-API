using Microsoft.AspNetCore.Identity;
using Proyecto.Domain.Entities.Identity;
using Proyecto.Domain.Interfaces;

namespace Proyecto.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<AppUser> _userManager;

        public UserRepository(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<AppUser> AddToRoleAsync(
            AppUser usuario,
            string roleName)
        {
            var userDb = await _userManager.FindByEmailAsync(usuario.Email!);

            if (userDb == null)
            {
                return null!;
            }

            await _userManager.AddToRoleAsync(userDb, roleName);

            return userDb;
        }

        public async Task<AppUser?> CreateUser(
            AppUser usuario,
            string password)
        {
            var result = await _userManager.CreateAsync(usuario, password);

            if (result.Succeeded)
            {
                return usuario;
            }

            return null;
        }

        public async Task<AppUser?> GetUserByEmail(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<bool> CheckPasswordAsync(
            string userId,
            string password)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return false;
            }

            return await _userManager.CheckPasswordAsync(user, password);
        }

        public async Task<bool> UserExists(string email)
        {
            return await _userManager.FindByEmailAsync(email) != null;
        }

        public async Task<List<string>> GetUserRoles(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return new List<string>();
            }

            var roles = await _userManager.GetRolesAsync(user);

            return roles.ToList();
        }
    }
}
