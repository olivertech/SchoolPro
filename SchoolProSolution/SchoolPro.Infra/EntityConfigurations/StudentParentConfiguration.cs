﻿namespace SchoolPro.Infra.EntityConfigurations
{
    public class StudentParentConfiguration : IEntityTypeConfiguration<StudentParent>
    {
        public void Configure(EntityTypeBuilder<StudentParent> builder)
        {
            //Common columns
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.SchoolKey).HasColumnName("client_school_key");

            //Entity columns
            builder.HasKey(x => new { x.StudentId, x.ParentId});

            //Relationship One-To-Many
            builder.HasOne(x => x.Student)
                   .WithMany(x => x.StudentParents)
                   .HasForeignKey(x => x.StudentId).HasConstraintName("student_id");

            builder.HasOne(x => x.Parent)
                   .WithMany(x => x.StudentParents)
                   .HasForeignKey(x => x.ParentId).HasConstraintName("parent_id");

            builder.Property(x => x.StudentId)
                   .HasColumnName("student_id");

            builder.Property(x => x.ParentId)
                  .HasColumnName("parent_id");

            builder.ToTable("Student_Parent");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
