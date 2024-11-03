namespace SchoolPro.Core.Entities.Base
{
    public class AuthorizedBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsActive { get; set; } = true;
        public DateOnly CreatedAt { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly? UpdatedAt { get; set; }
        public DateOnly? DeletedAt { get; set; }

        /// <summary>
        /// Chave que identifica uma escola e que irá definir 
        /// o isolamento do banco a nível de row nas tabelas dos sistemas.
        /// Ela será formada pela junção das keys ClientKey e SchoolKey,
        /// no formato ClientKey-SchoolKy.
        /// </summary>
        public string? ClientSchoolKey { get; set; }
    }
}
