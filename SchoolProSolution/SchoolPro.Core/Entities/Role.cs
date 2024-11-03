namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena os diversos tipos
    /// de papéis que um usuário pode assumir
    /// no sistema. Cada papel dá direito a 
    /// acessar um conjunto de funcionalidades
    /// dispostas no menu do sistema.
    /// </summary>
    public class Role : AuthorizedBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public IList<FeatureRole>? FeaturesRole { get; set; }
    }
}
