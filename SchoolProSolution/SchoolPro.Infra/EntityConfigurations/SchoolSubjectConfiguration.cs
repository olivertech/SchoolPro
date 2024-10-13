namespace SchoolPro.Infra.EntityConfigurations
{
    public class SchoolSubjectConfiguration : IEntityTypeConfiguration<SchoolSubject>
    {
        public void Configure(EntityTypeBuilder<SchoolSubject> builder)
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
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(500).IsRequired(false);

            builder.ToTable("School_Subject");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
