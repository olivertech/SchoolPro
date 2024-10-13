namespace SchoolPro.Infra.EntityConfigurations
{
    public class StudentParentConfiguration : IEntityTypeConfiguration<StudentParent>
    {
        public void Configure(EntityTypeBuilder<StudentParent> builder)
        {
            //Common columns
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.SchoolKey).HasColumnName("school_key");

            //Entity columns
            builder.HasKey(x => new { x.StudentId, x.ParentId});

            //Relationship One-To-Many
            builder.HasOne(sp => sp.Student)
                   .WithMany(s => s.StudentParents)
                   .HasForeignKey(sp => sp.StudentId).HasConstraintName("student_id");

            builder.HasOne(sp => sp.Parent)
                   .WithMany(p => p.StudentParents)
                   .HasForeignKey(sp => sp.ParentId).HasConstraintName("parent_id");

            builder.Property(o => o.StudentId)
                   .HasColumnName("student_id");

            builder.Property(o => o.ParentId)
                  .HasColumnName("parent_id");

            builder.ToTable("Student_Parent");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
