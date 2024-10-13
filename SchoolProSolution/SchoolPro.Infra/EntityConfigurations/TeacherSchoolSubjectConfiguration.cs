namespace SchoolPro.Infra.EntityConfigurations
{
    public class TeacherSchoolSubjectConfiguration : IEntityTypeConfiguration<TeacherSchoolSubject>
    {
        public void Configure(EntityTypeBuilder<TeacherSchoolSubject> builder)
        {
            //Common columns
            builder.Property(x => x.SchoolKey).HasColumnName("school_key");

            //Entity columns
            builder.HasKey(x => new { x.SchoolSubjectId, x.TeacherId });

            builder.HasOne(x => x.Teacher)
                .WithMany(x => x.TeacherSchoolSubjects)
                .HasForeignKey(x => x.TeacherId).HasConstraintName("teacher_Id");

            builder.HasOne(x => x.SchoolSubject)
                .WithMany(x => x.TeacherSchoolSubjects)
                .HasForeignKey(x => x.SchoolSubjectId).HasConstraintName("school_subject_Id");

            builder.Property(o => o.TeacherId)
                .HasColumnName("teacher_id");

            builder.Property(o => o.SchoolSubjectId)
                .HasColumnName("school_subject_id");

            builder.ToTable("Teacher_School_Subject");
        }
    }
}
