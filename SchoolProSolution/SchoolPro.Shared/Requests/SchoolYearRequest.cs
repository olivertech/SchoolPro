﻿namespace SchoolPro.Shared.Requests
{
    /// <summary>
    /// Request de Ano Letivo
    /// </summary>
    public class SchoolYearRequest : RequestBase, IRequest
    {
        public int Year { get; set; }
        public string? Description { get; set; }
        public decimal Budget { get; set; }
        public decimal Billing { get; set; }
    }
}
