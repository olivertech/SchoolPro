namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Features (Recursos do sistema)
    /// </summary>
    public class FeatureRequest : RequestBase, IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? MenuName { get; set; }
        public string? MenuTip { get; set; }
        public string? MenuEndPoint { get; set; }
        public string? MenuIcon { get; set; }
    }
}
