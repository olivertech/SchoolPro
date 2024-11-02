namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request do relacionamento dos professores com as matérias que ele leciona
    /// </summary>
    public class TeacherSchoolSubjectRequest : RequestBase, IRequest
    {
        public Guid? TeacherId { get; set; }
        public Guid? SchoolSubjectId { get; set; }
    }
}
