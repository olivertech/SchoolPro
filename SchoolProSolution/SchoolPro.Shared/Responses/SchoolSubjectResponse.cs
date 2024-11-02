namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response de Matéria Escolar
    /// </summary>
    public class SchoolSubjectResponse : ResponseBase, IResponse
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
