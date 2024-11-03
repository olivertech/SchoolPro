namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena os tipos de todos os documentos 
    /// armazenados no sistema, desde imagens, pdfs, vídeos,
    /// planilhas e muito mais.
    /// </summary>
    public class DocumentType : AuthorizedBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Icone { get; set; }
    }
}
