namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena todos os recursos disponíveis 
    /// no sistema, e que podem ser acessados pelos diversos
    /// tipos de perfis de acesso.
    /// </summary>
    public class Feature : AuthorizedBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        //Items used for visualization
        public string? MenuName { get; set; }
        public string? MenuTip { get; set; }
        public string? MenuEndPoint { get; set; }
        public string? MenuIcon { get; set; }
        public IList<FeatureRole>? FeaturesRole { get; set; }
    }
}
