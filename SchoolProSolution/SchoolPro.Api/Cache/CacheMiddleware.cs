using System.Runtime.Caching;

namespace SchoolPro.Api.Cache
{
    public class CacheMiddleware
    {
        //private readonly RequestDelegate _next;
        //private ObjectCache? _cache;

        //public CacheMiddleware(RequestDelegate next)
        //{
        //    _next = next;
        //}

        //public async Task InvokeAsync(HttpContext context)
        //{

        //    // Lógica para verificar o cache do usuário
        //    var userId = context.Items.TryGetValue("UserCpf", out var cpf);

        //    // Aqui você pode verificar se o cache do usuário está ativo
        //    bool isCacheActive = CheckUserCache(userId); // Implemente a lógica para verificar o cache.

        //    if (!isCacheActive)
        //    {
        //        // Se o cache não estiver ativo, você pode redirecionar ou retornar um resultado apropriado
        //        context.Response.Redirect("/Home/CacheExpired"); // Exemplo de redirecionamento
        //        return; // Não chama o próximo middleware
        //    }

        //    // Chama o próximo middleware na pipeline
        //    await _next(context);
        //}
    }
}
