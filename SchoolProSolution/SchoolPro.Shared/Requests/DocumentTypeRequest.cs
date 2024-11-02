namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request de Tipo de Documento
    /// </summary>
    public class DocumentTypeRequest : RequestBase, IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Icone { get; set; }
    }
}
