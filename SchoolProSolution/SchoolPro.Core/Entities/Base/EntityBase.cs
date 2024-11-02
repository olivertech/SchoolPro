namespace SchoolPro.Core.Entities.Base
{
    public class EntityBase : DefaultBase
    {
        /// <summary>
        /// Chave que identifica uma escola e que irá definir 
        /// o isolamento do banco a nível de row nas tabelas dos sistemas.
        /// Ela será formada pela junção das keys ClientKey e SchoolKey,
        /// no formato ClientKey-SchoolKy.
        /// </summary>
        public Guid ClientSchoolKey { get; set; } = Guid.NewGuid();
    }
}
