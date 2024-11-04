namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena os dados dos clientes, ou seja, 
    /// aquele que faz a assinatura do sistema, que inicialmete
    /// seria o dono ou gestor de uma escola ou uma rede de escolas.
    /// Um cliente pode ter uma ou mais escolas sendo gerenciadas
    /// por ele no sistema
    /// </summary>
    public class Client : AnonymousBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? ResponsableName { get; set; }
        public string? ResponsableEmail { get; set; }
        public string? ResponsableCellPhone1 { get; set; }
        public string? ResponsableCellPhone2 { get; set; }

        /// <summary>
        /// Chave única que identifica um cliente
        /// </summary>
        public string ClientSecretKey { get; set; } = null!;

        //Navigation Properties
        public IList<School>? Schools { get; set; }
    }
}
