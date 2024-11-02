namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Entidade que armazena o relacionamento dos usuários
    /// com os tipos de roles que ele pode ter no sistema.
    /// Um usuário, pode ter mais de uma role, o que permite
    /// que ele acesse mais de um conjunto de funcionalidades
    /// do sistema
    /// </summary>
    public class UserRole : EntityBase
    {
        //Navigation Property
        public Guid? UserId { get; set; }
        public User? User { get; set; }

        public Guid? RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
