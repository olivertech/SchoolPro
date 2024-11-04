namespace SchoolPro.Shared.Properties
{
    /// <summary>
    /// Classe estática que vai manter em memória, 
    /// as principais entidades de acesso ao sistema
    /// 
    /// </summary>
    public static class SessionProperties
    {
        public static Client Client { get; set; } = null!;
        public static School School { get; set; } = null!;
        public static User User { get; set; } = null!;
    }
}
