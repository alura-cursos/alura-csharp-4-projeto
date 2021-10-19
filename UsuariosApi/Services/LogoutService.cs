using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosApi.Data.Requests;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class LogoutService
    {
        private SignInManager<CustomIdentityUser> _signInManager;

        public LogoutService(SignInManager<CustomIdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public Result DeslogaUsuario()
        {
            Task resultadoIdentity = _signInManager.SignOutAsync();

            if (resultadoIdentity.IsCompletedSuccessfully)
            {
                return Result.Ok();
            }            
            return Result.Fail("Logout falhou");

        }
    }
}
