﻿namespace SchoolPro.Infra.EntityConfigurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
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
            builder.HasMany(d => d.Documents)
                .WithOne(d => d.Teacher)
                .HasForeignKey(d => d.TeacherId).HasConstraintName("teacher_Id");

            builder.ToTable("Teacher");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}