namespace SchoolPro.Core.Entities
{
    public class StudentClass : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int Capacity { get; set; } = 0;

        //One-To-many
        public IList<Student>? Students { get; set; }
    }
}
