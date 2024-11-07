namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena os dados dos usuários do sistema
    /// e seu tipo de acesso, por meio da role
    /// </summary>
    public class User : AnonymousBase
    {
        public string? Document { get; set; } // Armazena o CPF 
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PicturePath { get; set; }

        //Navigation Properties
        public Guid SchoolId { get; set; }
        public School? School { get; set; }
        public Guid? AccessTokenId { get; set; }
        public AccessToken? AccessToken { get; set; }
        public Guid? RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
