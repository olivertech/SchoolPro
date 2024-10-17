namespace SchoolPro.Infra.EntityConfigurations
{
    public class StudentGradeConfiguration : IEntityTypeConfiguration<StudentGrade>
    {
        public void Configure(EntityTypeBuilder<StudentGrade> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasColumnName("created_at");
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");
            builder.Property(x => x.SchoolKey).HasColumnName("school_key");

            builder.Property(x => x.Id).HasColumnName("id");

            //Entity columns
            builder.Property(x => x.Id).HasColumnName("Id").HasValueGenerator<GuidValueGenerator>();
            builder.Property(x => x.Grade).HasColumnName("grade").IsRequired();

            builder.Property(x => x.SchoolSubjectId).HasColumnName("school_subject_id").IsRequired();
            builder.Property(x => x.StudentId).HasColumnName("student_id").IsRequired();
            builder.Property(x => x.StudentClassId).HasColumnName("student_class_id").IsRequired();

            builder.ToTable("Student_Grade");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
