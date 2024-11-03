namespace SchoolPro.Infra.EntityConfigurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
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
            builder.Property(x => x.Title).HasColumnName("title").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.FilePath).HasMaxLength(250).HasColumnName("file_path").IsRequired();
            builder.Property(x => x.ParentId).HasColumnName("parent_id");
            builder.Property(x => x.SchoolId).HasColumnName("school_id");
            builder.Property(x => x.StudentId).HasColumnName("student_id");
            builder.Property(x => x.TeacherId).HasColumnName("teacher_id");
            builder.Property(x => x.DocumentTypeId).HasColumnName("document_type_id");

            builder.ToTable("Document");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
