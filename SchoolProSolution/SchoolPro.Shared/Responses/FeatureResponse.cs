namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Features (Recursos do sistema)
    /// </summary>
    public class FeatureResponse : ResponseBase, IResponse
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? MenuName { get; set; }
        public string? MenuTip { get; set; }
        public string? MenuEndPoint { get; set; }
        public string? MenuIcon { get; set; }
    }
}
