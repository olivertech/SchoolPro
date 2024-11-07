using Microsoft.AspNetCore.Mvc.Filters;
using SchoolPro.Api.Cache;

namespace SchoolPro.Api.Filter
{
    /// <summary>
    /// Essa classe é um filtro de validação do cache do usuário,
    /// que vai recuperar o cache, validar o tempo de inatividade
    /// e se tudo estiver ok, mantém o usuário logado, caso 
    /// contrário, desloga ele.
    /// </summary>
    public class CacheCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Recupero o nome da controller
            var controllerName = context.Controller.GetType().Name;

            // Recupero o nome da action
            var actionName = context.RouteData.Values["action"]?.ToString();

            if (controllerName != "LoginController" && actionName != "Auth" && actionName != "Logout")
            {
                var userId = context.HttpContext.Session.GetString("UserId");

                if (!string.IsNullOrEmpty(userId))
                {
                    // Verifica se o cache do usuário está ativo
                    bool isCacheActive = CheckUserCache(Guid.Parse(userId));

                    if (!isCacheActive)
                    {
                        // Caso a session não exista ou esteja inativa por muito tempo,
                        // redirecionar para a tela de login.
                        context.Result = new RedirectToActionResult("Auth", "Login", null);
                    }
                }
            }

            base.OnActionExecuting(context);
        }

        /// <summary>
        /// Método que verifica se o cache do usuário existe e se está 
        /// abaixo do tempo de inatividade que é por padrão 20 minutos
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        private bool CheckUserCache(Guid userId)
        {
            SessionConfiguration? session = SessionConfigurationHandler.GetSessionConfiguration(userId);

            if (session == null)
                return false;
            else
            {
                //Verifica se o usuário
                var nowPlusTwenty = DateTime.Now.AddMinutes(20);
                var invalidSession = session.SessionLastAt.CompareTo(nowPlusTwenty) < 0;

                if (invalidSession)
                {
                    // Se o tempo de inatividade é maior que o tempo determinado, apaga o cache
                    SessionConfigurationHandler.ClearSessionConfiguration(userId);
                    return false;
                }
                else
                {
                    // Se o tempo estiver abaixo do tempo de inatividade determinado, atualiza o tempo e segue
                    SessionConfigurationHandler.UpdateSessionConfiguration(userId, session);
                    return true;
                }
            }
        }
    }
}
