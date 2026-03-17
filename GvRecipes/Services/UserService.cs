using System.Security.Claims;
using GvRecipes.Helpers;
using GvRecipes.Models;
using GvRecipes.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace GvRecipes.Services;

public class UserService : IUserService
{
    private SignInManager<Usuario> _signInManager;
    private UserManager<Usuario> _userManager;
    private readonly ILogger<UserService> _logger;

    public UserService(
        SignInManager<Usuario> signInManager,
        UserManager<Usuario> userManager,
        ILogger<UserService> logger
    )
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _logger = logger;

    }
    public async Task<SignInResult> Login(LoginVM login)
    {
        string userName = login.Email;
        if (Helper.IsValidEmail(login.Email))
        {
            var user = await _userManager.FindByEmailAsync(login.Email);
            if (user != null)
                userName = user.UserName;
        }

        var result = await _signInManager.PasswordSignInAsync(
            userName, login.Senha, login.Lembrar, lockoutOnFailure: true
        );
        if (result.Succeeded)
            _logger.LogInformation($"Usuário '{userName}' acessou o sistema.");
        if (result.IsLockedOut)
            _logger.LogWarning($"Usuário '{userName}' foi bloqueado por tentativas de login inválidas.");
        return result;
    }

    public async Task Logout()
    {
        _logger.LogInformation($"Usuário '{ClaimTypes.Email}' saiu do sistema.");
        await _signInManager.SignOutAsync();
    }
}
