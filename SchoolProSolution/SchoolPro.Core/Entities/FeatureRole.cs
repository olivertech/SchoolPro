namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena o relacionamento entre
    /// os recursos do sistema e quais roles/papéis
    /// podem acessar cada recurso.
    /// </summary>
    public class FeatureRole : AuthorizedBase
    {
        public Guid? FeatureId { get; set; }
        public Feature? Feature { get; set; }

        public Guid? RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
