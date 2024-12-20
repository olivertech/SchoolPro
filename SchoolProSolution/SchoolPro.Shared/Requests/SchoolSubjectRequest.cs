﻿namespace SchoolPro.Shared.Requests
{
    /// <summary>
    /// Request de Matéria Escolar
    /// </summary>
    public class SchoolSubjectRequest : RequestBase, IRequest
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
