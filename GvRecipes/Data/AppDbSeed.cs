using GvRecipes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GvRecipes.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Popular Perfil


        List<IdentityRole> roles = new()
        {
            new ()
            {
                Id = "8f3136ac-d7d9-4350-b20f-ed0e23c638bb",
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR",
            },
            new ()
            {
                Id = "ed1b0daf-5def-413b-8fdf-fd1771520351",
                Name = "Moderador",
                NormalizedName = "MODERADOR",
            },
            new ()
            {
                Id = "a2537ca1-4212-43c2-988e-c7c1c09b8090",
                Name = "Usuario",
                NormalizedName = "USUARIO",
            },
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Popular Usuario
        List<Usuario> usuarios = new()
        {
            new()
            {
                Id = "81e87409-2e0d-4153-abea-65917a029f8d",
                Nome = "Gabriel Felipe Vizon",
                UserName = "GvRecipes@gmail.com",
                NormalizedUserName = "GVRECIPES@GMAIL.COM",
                Email = "GvRecipes@gmail.com",
                NormalizedEmail = "GVRECIPES@GMAIL.COM",
                DataNascimento = DateTime.Parse("11/07/2007"),
                Foto = "/img/usuarios/81e87409-2e0d-4153-abea-65917a029f8d.png",
                EmailConfirmed = true,
                LockoutEnabled = false,
            },

            new()
            {
                Id = "698e4430-48de-4346-82ba-7437648192e9",
                Nome = "Gabriel Felipe Vizon",
                UserName = "gabrielvizon1931@gmail.com",
                NormalizedUserName = "GABRIELVIZON1931@GMAIL.COM",
                Email = "gabrielvizon1931@gmail.com",
                NormalizedEmail = "GABRIELVIZON1931@GMAIL.COM",
                DataNascimento = DateTime.Parse("11/07/2007"),
                Foto = "/img/usuarios/698e4430-48de-4346-82ba-7437648192e9.png",
                EmailConfirmed = true,
                LockoutEnabled = true,
            }

        };
        foreach (var usuario in usuarios)
        {
            PasswordHasher<IdentityUser> passwordHasher = new();
            usuario.PasswordHash = passwordHasher.HashPassword(usuario, "123456");
        }
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Popular UsuarioPerfil

        List<IdentityUserRole<string>> userRoles = new()
        {
           new()
           {
                UserId = usuarios[0].Id,
                RoleId = roles[0].Id,
           },
              new()
              {
                 UserId = usuarios[1].Id,
                 RoleId = roles[2].Id,
              },
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion

        #region Popular Categoria
        List<Categoria> categorias = new()
        {
            new()
            {
                Id = 1,
                Nome = "Massas",
                Icone = "fas fa-pizza-slice",
            },
            new()
            {
                Id = 2,
                Nome = "Peixes",
                Icone = "fas fa-fish",
            },
            new()
            {
                Id = 3,
                Nome = "Vegetariano",
                Icone = "fas fa-leaf",
            },
            new()
            {
                Id = 4,
                Nome = "Carnes",
                Icone = "fas fa-drumstick-bite",
            },
            new()
            {
                Id = 5,
                Nome = "Doces",
                Icone = "fas fa-cake-candles",
            },
            new()
            {
                Id = 6,
                Nome = "Pães",
                Icone = "fas fa-bread-slice",
            },
            new()
            {
                Id = 7,
                Nome = "Sopas",
                Icone = "fas fa-mug-hot",
            },
            new()
            {
                Id = 8,
                Nome = "Picantes",
                Icone = "fas fa-pepper-hot",
            },
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion

        #region Popular Ingredientes
        List<Ingrediente> ingredientes = new() {
            new Ingrediente() {
                Id = 1,
                Nome = "Carne Moída"
            },
            new Ingrediente() {
                Id = 2,
                Nome = "Pimentão Verde"
            },
            new Ingrediente() {
                Id = 3,
                Nome = "Pimentão Vermelho"
            },
            new Ingrediente() {
                Id = 4,
                Nome = "Pimentão Amarelo"
            },
            new Ingrediente() {
                Id = 5,
                Nome = "Cebola"
            },
            new Ingrediente() {
                Id = 6,
                Nome = "Curry"
            },
            new Ingrediente() {
                Id = 7,
                Nome = "Pimenta Calabresa"
            },
            new Ingrediente() {
                Id = 8,
                Nome = "Páprica Picante"
            },
            new Ingrediente() {
                Id = 9,
                Nome = "Sal"
            },
            new Ingrediente() {
                Id = 10,
                Nome = "Orégano"
            },
            new Ingrediente() {
                Id = 11,
                Nome = "Pão Sirio"
            },
            new Ingrediente() {
                Id = 12,
                Nome = "Cream Cheese"
            },
            new Ingrediente() {
                Id = 13,
                Nome = "Cheddar"
            },
            new Ingrediente() {
                Id = 14,
                Nome = "Azeite"
            },

            // PARMEGIANA DE FRANGO -----------------------------------------------------------------------------------
            new Ingrediente() {
                Id = 15,
                Nome = "Peito de Frango em Filé"
            },
            new Ingrediente() {
                Id = 16,
                Nome = "Pimenta do Reino"
            },
            new Ingrediente() {
                Id = 17,
                Nome = "Alho"
            },
            new Ingrediente() {
                Id = 18,
                Nome = "Limão"
            },
            new Ingrediente() {
                Id = 19,
                Nome = "Ovo"
            },
            new Ingrediente() {
                Id = 20,
                Nome = "Farinha de Trigo"
            },
            new Ingrediente() {
                Id = 21,
                Nome = "Farinha de Rosca"
            },
            new Ingrediente() {
                Id = 22,
                Nome = "Molho de Tomate"
            },
            new Ingrediente() {
                Id = 23,
                Nome = "Queijo Mussarela"
            },
            new Ingrediente() {
                Id = 24,
                Nome = "Queijo Parmesão"
            },
            new Ingrediente() {
                Id = 25,
                Nome = "Óleo"
            },
             new Ingrediente() {
                Id = 26,
                Nome = "Orégano"
             },
        };
        builder.Entity<Ingrediente>().HasData(ingredientes);
        #endregion

        #region Populate Receita
        List<Receita> receitas = new() {
            new Receita() {
                Id = 1,
                Nome = "Carne Moída Mexicana",
                Descricao = "Prato perfeito para um lanche rápido ou mesmo uma refeição picante. Carne moída, pimentões, temperos e muito queijooooo",
                CategoriaId = 4,
                Dificuldade = Dificuldade.Fácil,
                Rendimento = 5,
                TempoPreparo = "20 minutos",
                Foto = "/img/receitas/1.jpg",
                UsuarioId = usuarios[0].Id,
            },
            new Receita() {
                Id = 2,
                Nome = "Frango à Parmegiana ",
                Descricao = "Prato delicioso e bem servido: frango empanado crocante, coberto com molho de tomate, queijo derretido e temperos que deixam tudo ainda mais saboroso.",
                CategoriaId = 4,
                Dificuldade = Dificuldade.Médio,
                Rendimento = 2,
                TempoPreparo = "45 minutos",
                Foto = "/img/receitas/2.jpg",
                UsuarioId = usuarios[0].Id,
            }
        };
        builder.Entity<Receita>().HasData(receitas);
        #endregion

        #region Popular Preparo
        List<Preparo> preparos = new()
        {
            new()
            {
                Id = 1,
                ReceitaId = 1,
                Texto = "Comece pela preparação dos ingredientes, pique os pimentões e a cebola em pequenos cubos, se preferir você também pode usar um processador de alimentos."
            },
            new()
            {
                Id = 2,
                ReceitaId = 1,
                Texto = "Coloque a carne moída para fritar em uma panela com um pouco de azeite."
            },
            new()
            {
                Id = 3,
                ReceitaId = 1,
                Texto = "Quando a carne moída já não estiver mais crua, adicione os pimentões e a cebola, mexendo bem para misturar todos os ingredientes."
            },
            new()
            {
                Id = 4,
                ReceitaId = 1,
                Texto = "Aguarde alguns instante e adicione os temperos, mexendo novamente para misturar."
            },
            new()
            {
                Id = 5,
                ReceitaId = 1,
                Texto = "Frite por mais alguns minutos a carne com os demais ingredientes."
            },
            new()
            {
                Id = 6,
                ReceitaId = 1,
                Texto = "Adicione o Cream Cheese e o Queijo Cheddar, mexendo bem para evitar que queime o fundo e ajudar os queijos a derreterem."
            },
            new()
            {
                Id = 7,
                ReceitaId = 1,
                Texto = "Quando os queijos já estiverem bem derretidos e misturados com os demais ingredientes, sirva acompanhado do Pão Sirio ou de Doritos."
            },
        // RECEITA ID 2 -----------------------------------------------------------------------------------

            new()
            {
                Id = 8,
                ReceitaId = 2,
                Texto = "Tempere os filés de frango com sal, pimenta e temperos de sua preferência."
            },
            new()
            {
                Id = 9,
                ReceitaId = 2,
                Texto = "Empane os filés passando primeiro na farinha de trigo, depois nos ovos batidos e por último na farinha de rosca."
            },
            new()
            {
                Id = 10,
                ReceitaId = 2,
                Texto = "Frite os filés em óleo quente até ficarem dourados e bem cozidos."
            },
            new()
            {
                Id = 11,
                ReceitaId = 2,
                Texto = "Coloque os filés fritos em um refratário e cubra com molho de tomate."
            },
            new()
            {
                Id = 12,
                ReceitaId = 2,
                Texto = "Adicione queijo por cima e leve ao forno para gratinar até derreter e dourar."
            },
            new()
            {
                Id = 13,
                ReceitaId = 2,
                Texto = "Sirva quente, acompanhado de arroz branco ou salada."
            }
        };
        builder.Entity<Preparo>().HasData(preparos);
        #endregion

        #region Receita Ingrediente
        List<ReceitaIngrediente> receitaIngredientes = new() {
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 1,
                Quantidade = "500g"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 3,
                Quantidade = "1 pequeno"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 4,
                Quantidade = "1 pequeno"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 5,
                Quantidade = "1 pequeno"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 6,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 7,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 8,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 9,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 10,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 11,
                Quantidade = "A vontade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 12,
                Quantidade = "200g"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 13,
                Quantidade = "200g"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 14,
                Quantidade = "Um pouco"
            },

            // RECEITA ID 2 -----------------------------------------------------------------------------------
            new ReceitaIngrediente(){
                ReceitaId = 2,
                IngredienteId = 15,
                Quantidade = "2 unidades "
            },
            new ReceitaIngrediente(){
                ReceitaId = 2,
                IngredienteId = 9,
                Quantidade = "1 colher de chá (sal)"
            },
            new ReceitaIngrediente(){
                ReceitaId = 2,
                IngredienteId = 16,
                Quantidade = "1 colher de chá (pimenta)"
            },
            new ReceitaIngrediente(){
                ReceitaId = 2,
                IngredienteId = 17,
                Quantidade = "2 dentes (alho)"
            },
            new ReceitaIngrediente(){
                ReceitaId = 2,
                IngredienteId = 18,
                Quantidade = "1/2 unidade (limão)"
            },
            new ReceitaIngrediente(){
                ReceitaId = 2,
                IngredienteId = 19,
                Quantidade = "2 unidades (ovos)"
            },
            new ReceitaIngrediente(){
                ReceitaId = 2,
                IngredienteId = 20,
                Quantidade = "1 xícara (farinha de trigo)"
            },
            new ReceitaIngrediente(){
                ReceitaId = 2,
                IngredienteId = 21,
                Quantidade = "1 xícara (farinha de rosca)"
            },
            new ReceitaIngrediente(){
                ReceitaId = 2,
                IngredienteId = 22,
                Quantidade = "300 g (molho de tomate)"
            },
            new ReceitaIngrediente(){
                ReceitaId = 2,
                IngredienteId = 23,
                Quantidade = "200 g (queijo mussarela)"
            },
            new ReceitaIngrediente(){
                ReceitaId = 2,
                IngredienteId = 24,
                Quantidade = "50 g (queijo parmesão ralado)"
            },
            new ReceitaIngrediente(){
                ReceitaId = 2,
                IngredienteId = 26,
                Quantidade = "1 colher de chá (orégano)"
            },
            new ReceitaIngrediente(){
                ReceitaId = 2,
                IngredienteId = 25,
                Quantidade = "300 ml (óleo para fritar)"
            },
            //RECEITA ID 3 ---------------------------------------------------------
        };
        builder.Entity<ReceitaIngrediente>().HasData(receitaIngredientes);
        #endregion

    }
}
