namespace SchoolPro.Infra.EntityConfigurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasColumnName("created_at");
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");
            builder.Property(x => x.SchoolKey).HasColumnName("school_key");

            builder.Property(x => x.Id).HasColumnName("id");

            //Entity columns
            builder.Property(x => x.Id).HasColumnName("Id").HasValueGenerator<GuidValueGenerator>();
            builder.Property(x => x.Title).HasColumnName("title").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500).HasColumnName("description");
            builder.Property(x => x.FilePath).HasMaxLength(250).HasColumnName("file_path").IsRequired();
            builder.Property(x => x.ParentId).HasColumnName("parent_id");
            builder.Property(x => x.SchoolId).HasColumnName("school_id");
            builder.Property(x => x.StudentId).HasColumnName("student_id");
            builder.Property(x => x.TeacherId).HasColumnName("teacher_id");

            builder.ToTable("Document");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
