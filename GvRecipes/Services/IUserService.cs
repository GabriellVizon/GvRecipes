using GvRecipes.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace GvRecipes.Services;

public interface IUserService
{
    Task<SignInResult> Login(LoginVM login);
    Task Logout();
}
