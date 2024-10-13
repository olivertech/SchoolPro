using SchoolPro.Core.Entities.Base;

namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Classe que armazena os dados das
    /// salas de aula
    /// </summary>
    public class Room : EntityBase
    {
        public string Name { get; set; } = null!;

        //Navigation Property
        public School? School { get; set; }
    }
}
