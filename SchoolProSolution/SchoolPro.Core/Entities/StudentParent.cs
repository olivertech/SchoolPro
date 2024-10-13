using SchoolPro.Core.Entities.Base;

namespace SchoolPro.Core.Entities
{
    public class StudentParent : EntityBase
    {
        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }

        public Guid? ParentId { get; set; }
        public Parent? Parent { get; set; }
    }
}
