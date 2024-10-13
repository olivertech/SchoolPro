namespace SchoolPro.Core.Entities
{
    public class StudentParent : RelationBase
    {
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }

        public Guid? ParentId { get; set; }
        public Parent? Parent { get; set; }
    }
}
