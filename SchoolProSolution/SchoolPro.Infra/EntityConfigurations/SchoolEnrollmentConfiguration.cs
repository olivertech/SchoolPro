﻿namespace SchoolPro.Infra.EntityConfigurations
{
    public class SchoolEnrollmentConfiguration : IEntityTypeConfiguration<SchoolEnrollment>
    {
        public void Configure(EntityTypeBuilder<SchoolEnrollment> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasValueGenerator<GuidValueGenerator>();
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasColumnName("created_at").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");
            builder.Property(x => x.ClientSchoolKey).HasColumnName("client_school_key").IsRequired();

            //Entity columns
            builder.Property(x => x.Enrollment).HasColumnName("enrollment").HasMaxLength(25).IsRequired();
            builder.Property(x => x.Approved).HasColumnName("approved");
            builder.Property(x => x.FinalGrade).HasColumnName("final_grade").HasMaxLength(10).IsRequired(false);
            builder.Property(x => x.StudentId).HasColumnName("student_id");
            builder.Property(x => x.SchoolYearId).HasColumnName("school_year_id");

            builder.ToTable("School_Enrollment");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
