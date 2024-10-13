namespace SchoolPro.Core.Entities.Base
{
    public class EntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Chave que identifica uma escola e que irá definir 
        /// o isolamento do banco a nível de row nas tabelas dos sistemas
        /// </summary>
        public Guid SchoolKey { get; set; }
    }
}
