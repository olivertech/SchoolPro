namespace SchoolPro.Shared.Entities
{
    /// <summary>
    /// Request do relacionamento dos professores com as matérias que ele leciona
    /// </summary>
    public class TeacherSchoolSubjectRequest : RequestBase, IRequest
    {
        //Navigation Property
        public Guid? TeacherId { get; set; }
        public TeacherRequest? Teacher { get; set; }
        public Guid? SchoolSubjectId { get; set; }
        public SchoolSubjectRequest? SchoolSubject { get; set; }
    }
}
