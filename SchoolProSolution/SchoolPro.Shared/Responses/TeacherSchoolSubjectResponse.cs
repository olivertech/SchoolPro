namespace SchoolPro.Shared.Responses
{
    /// <summary>
    /// Response do relacionamento dos professores com as matérias que ele leciona
    /// </summary>
    public class TeacherSchoolSubjectResponse : ResponseBase, IResponse
    {
        public Guid? TeacherId { get; set; }
        public Guid? SchoolSubjectId { get; set; }
    }
}
