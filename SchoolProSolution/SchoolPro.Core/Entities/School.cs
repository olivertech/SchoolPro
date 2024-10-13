﻿using SchoolPro.Core.Entities.Base;

namespace SchoolPro.Core.Entities
{
    /// <summary>
    /// Classe que armazena os dados da
    /// escola
    /// </summary>
    public class School : EntityBase
    {
        public string Name { get; set; } = null!;

        //Navigation Property
        public Address? Address { get; set; }
    }
}
