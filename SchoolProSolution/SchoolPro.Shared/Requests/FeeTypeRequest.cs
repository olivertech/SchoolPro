﻿namespace SchoolPro.Shared.Requests
{
    /// <summary>
    /// Request de Tipo de Taxa
    /// </summary>
    public class FeeTypeRequest : RequestBase, IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
