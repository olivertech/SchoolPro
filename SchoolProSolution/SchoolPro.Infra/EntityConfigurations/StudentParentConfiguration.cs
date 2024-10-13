using Microsoft.EntityFrameworkCore;

namespace SchoolPro.Infra.EntityConfigurations
{
    public class StudentParentConfiguration : IEntityTypeConfiguration<StudentParent>
    {
        public void Configure(EntityTypeBuilder<StudentParent> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasColumnName("created_at");
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");

            //Entity columns
            builder.Property(x => x.Id).HasColumnName("Id").HasValueGenerator<GuidValueGenerator>();

            //Relationship One-To-Many
            builder.HasOne(sp => sp.Student)
                   .WithMany(s => s.StudentParents)
                   .HasForeignKey(sp => sp.StudentId).HasConstraintName("student_id");

            builder.HasOne(sp => sp.Parent)
                   .WithMany(p => p.StudentParents)
                   .HasForeignKey(sp => sp.ParentId).HasConstraintName("parent_id");

            builder.ToTable("StudentParent");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
