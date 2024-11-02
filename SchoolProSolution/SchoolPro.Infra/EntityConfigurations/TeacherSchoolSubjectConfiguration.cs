namespace SchoolPro.Infra.EntityConfigurations
{
    public class TeacherSchoolSubjectConfiguration : IEntityTypeConfiguration<TeacherSchoolSubject>
    {
        public void Configure(EntityTypeBuilder<TeacherSchoolSubject> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasValueGenerator<GuidValueGenerator>();
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.ClientSchoolKey).HasColumnName("client_school_key");

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

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
