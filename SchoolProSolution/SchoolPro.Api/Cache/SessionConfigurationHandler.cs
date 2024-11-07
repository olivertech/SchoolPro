namespace SchoolPro.Api.Cache
{
    public static class SessionConfigurationHandler
    {
        private static ObjectCache? _cache;
        private static double _cacheMinutes = 120;

        /// <summary>
        /// Cada usuário que se loga no sistema vai ter 
        /// seus principais dados armazenados em cache
        /// para facilitar consultas e tomadas de
        /// decisão no sistema, sem precisar recorrer
        /// a acessos ao banco de dados
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="session"></param>
        public static void SaveSessionConfiguration(Guid userId, SessionConfiguration session)
        {
            if (_cache == null)
            {
                _cache = MemoryCache.Default;
                session.SessionCreatedAt = DateTime.Now;

                _cache.Add(userId.ToString(), session, GetPolity());
            }
            else
            {
                UpdateSessionConfiguration(userId, session);
            }
        }

        /// <summary>
        /// Método que recupera a sessão em cache com todos os
        /// dados do usuário logado no sistema
        /// </summary>
        /// <param name="userDocument"></param>
        /// <returns></returns>
        public static SessionConfiguration? GetSessionConfiguration(Guid userId)
        {
            SessionConfiguration? userConfiguration = null;

            if (_cache != null)
            {
                userConfiguration = _cache.Get(userId.ToString()) as SessionConfiguration;
            }

            return userConfiguration;
        }

        /// <summary>
        /// Método que atualiza a sessão em cache do usuário logado,
        /// atualizando a propriedade SessionLastAt para a data e
        /// hora corrente
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="session"></param>
        public static void UpdateSessionConfiguration(Guid userId, SessionConfiguration session)
        {
            if (_cache != null)
            {
                session.SessionLastAt = DateTime.Now;
                _cache.Set(userId.ToString(), session, GetPolity());
            }
        }

        /// <summary>
        /// Método que remove uma sessão de um usuário que está se deslogando do site
        /// </summary>
        /// <param name="userDocument"></param>
        public static void ClearSessionConfiguration(Guid userId)
        {
            if (_cache != null)
            {
                _cache?.Remove(userId.ToString());
            }
        }

        /// <summary>
        /// Método interno que cria a policy de tempo do memorycache
        /// </summary>
        /// <returns></returns>
        private static CacheItemPolicy GetPolity()
        {
            CacheItemPolicy policy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(_cacheMinutes)
            };

            return policy;
        }
    }
}
