namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Tipo de Documento
    /// </summary>
    public class DocumentTypeResponse : ResponseBase, IResponse
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Icone { get; set; }
    }
}
