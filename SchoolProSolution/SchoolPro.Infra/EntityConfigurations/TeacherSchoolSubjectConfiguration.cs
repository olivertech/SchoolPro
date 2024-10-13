namespace SchoolPro.Infra.EntityConfigurations
{
    public class TeacherSchoolSubjectConfiguration : IEntityTypeConfiguration<TeacherSchoolSubject>
    {
        public void Configure(EntityTypeBuilder<TeacherSchoolSubject> builder)
        {
            //Common columns
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasColumnName("created_at");
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");

            //Entity columns
            builder.HasKey(x => new { x.SchoolSubjectId, x.TeacherId });

            builder.HasOne(nu => nu.Teacher)
                .WithMany(x => x.TeacherSchoolSubjects)
                .HasForeignKey(ur => ur.TeacherId).HasConstraintName("teacher_Id");

            builder.HasOne(x => x.SchoolSubject)
                .WithMany(x => x.TeacherSchoolSubjects)
                .HasForeignKey(x => x.SchoolSubjectId).HasConstraintName("school_subject_Id");

            builder.ToTable("Teacher_School_Subject");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
