namespace SchoolPro.Core.Entities
{
    public class TeacherSchoolSubject : RelationBase
    {
        //Navigation Property
        public Guid? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public Guid? SchoolSubjectId { get; set; }
        public SchoolSubject? SchoolSubject { get; set; }
    }
}
