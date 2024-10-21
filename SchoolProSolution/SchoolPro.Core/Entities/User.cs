namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena os dados dos usuários do sistema
    /// e seu tipo de acesso, por meio da role
    /// </summary>
    public class User : EntityBase
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PicturePath { get; set; }

        //Navigation Properties
        public Guid ClientId { get; set; }
        public Client? Client { get; set; }
        public IList<UserRole>? UserRoles { get; set; }
    }
}
