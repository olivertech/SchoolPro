namespace SchoolPro.Infra.EntityConfigurations
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
            builder.Property(x => x.ClientSchoolKey).HasColumnName("client_school_key");

            builder.Property(x => x.Id).HasColumnName("id");

            //Entity columns
            builder.Property(x => x.Id).HasColumnName("Id").HasValueGenerator<GuidValueGenerator>();
            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.Birthdate).HasColumnName("birthdate").IsRequired(false);
            builder.Property(x => x.Gender).HasColumnName("gender").HasMaxLength(1).IsRequired(false);
            builder.Property(x => x.ContactId).HasColumnName("address_id");

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
