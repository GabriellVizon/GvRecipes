using GvRecipes.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace GvRecipes.Services;

public interface IUserService
{
    Task<UsuarioVM> GetUsuarioLogado();
    Task<SignInResult> Login(LoginVM login);
    Task Logout();
}
