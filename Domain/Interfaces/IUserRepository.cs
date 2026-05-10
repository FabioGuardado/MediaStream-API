using Proyecto.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Domain.Interfaces
{
    public interface IUserRepository
    {
        /// <summary>
        /// Esto me permite buscar usuarios por email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<AppUser?> GetUserByEmail(string email);

        /// <summary>
        /// Para crear un nuevo usuario en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<AppUser> CreateUser(AppUser usuario, string password);

        /// <summary>
        /// Para agregar un usuario a un rol especifico. lo que es util para gestionar permisos y accesos dentro de la aplicacion
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<AppUser> AddToRoleAsync(AppUser usuario, string roleName);

        /// <summary>
        /// Para validar que la contraseña pertenece al usuario
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<bool> CheckPasswordAsync(string userId, string password);


        Task<bool> UserExists(string email);

        Task<List<string>> GetUserRoles(string email);
    }
}
