﻿namespace SchoolPro.Infra.EntityConfigurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasColumnName("created_at");
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");

            //Entity columns
            builder.Property(x => x.Id).HasColumnName("Id").HasValueGenerator<GuidValueGenerator>();
            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Birthdate).HasColumnName("birthdate");
            builder.Property(x => x.Gender).HasColumnName("gender").HasMaxLength(1);

            //Relationship One-To-Many
            builder.HasMany(d => d.Documents)
                .WithOne(d => d.Student)
                .HasForeignKey(d => d.StudentId).HasConstraintName("student_Id");

            builder.ToTable("Student");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}