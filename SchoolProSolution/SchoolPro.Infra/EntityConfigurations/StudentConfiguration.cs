namespace SchoolPro.Infra.EntityConfigurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
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
            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Birthdate).HasColumnName("birthdate").IsRequired(false);
            builder.Property(x => x.Gender).HasColumnName("gender").HasMaxLength(1).IsRequired(false);
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(1).IsRequired(false);
            builder.Property(x => x.ContactId).HasColumnName("contact_id");
            builder.Property(x => x.StudentClassId).HasColumnName("student_class_id");

            //Relationship One-To-Many
            builder.HasMany(d => d.Documents)
                .WithOne(d => d.Student)
                .HasForeignKey(d => d.StudentId).HasConstraintName("student_Id");

            builder.HasMany(d => d.StudentParents)
                .WithOne(d => d.Student)
                .HasForeignKey(d => d.StudentId).HasConstraintName("student_Id");

            builder.ToTable("Student");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
