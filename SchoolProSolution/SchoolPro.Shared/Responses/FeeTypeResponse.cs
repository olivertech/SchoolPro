namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Tipo de Taxa
    /// </summary>
    public class FeeTypeResponse : ResponseBase, IResponse
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
