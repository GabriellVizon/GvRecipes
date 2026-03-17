using GvRecipes.Services;
using GvRecipes.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GvRecipes.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;
    private readonly IUserService _userService;

    public AccountController(
        ILogger<AccountController> logger,
        IUserService userService
    )
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpGet]
    public IActionResult Login(string returnUrl = null)
    {
        if (User.Identity.IsAuthenticated)
            return RedirectToAction("Index", "Home");
        var model = new LoginVM
        {
            UrlRetorno = returnUrl ?? Url.Content("~/")
        };
        return View(model);
    }


    [HttpGet]
    public async Task<IActionResult> Login([FromBody] LoginVM model)
    {
        try
        {
            // Validação do lado do servidor
            if (!ModelState.IsValid)
            {
                return Json(new
                {
                    success = false,
                    message = "Dados de login inválidos. Verifique os campos preenchidos."
                });
            }
            var result = await _userService.Login(model);

            if (result.Succeeded)
            {
                return Json(new
                {
                    success = true,
                    message = "Login realizado com sucesso! Redirecionando...",
                    redirectUrl = model.UrlRetorno
                });
            }

            if (result.IsLockedOut)
            {
                return Json(new
                {
                    success = false,
                    message = "Conta bloqueada devido a múltiplas tentativas de login inválidas. Tente novamente mais tarde."
                });
            }
    
            if (result.IsNotAllowed)
            {
                return Json(new
                {
                    success = false,
                    message = "Usário não tem permissão para acessar o sistema."  
                });
            }

            return Json(new
            {
                success = false,
                message = "Email ou senha incorretos. Tente novamente."
            });

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao processar login.");
            return Json(new
            {
                success = false,
                message = "Ocorreu um erro interno. Tente novamente mais tarde."
            });
        }
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
