namespace SchoolPro.Core.Entities.Base
{
    public class RelationBase
    {
        /// <summary>
        /// Chave que identifica uma escola e que irá definir 
        /// o isolamento do banco a nível de row nas tabelas dos sistemas
        /// </summary>
        public Guid SchoolKey { get; set; }
    }
}
