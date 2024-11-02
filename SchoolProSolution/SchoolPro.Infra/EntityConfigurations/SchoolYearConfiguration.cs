namespace SchoolPro.Infra.EntityConfigurations
{
    public class SchoolYearConfiguration : IEntityTypeConfiguration<SchoolYear>
    {
        public void Configure(EntityTypeBuilder<SchoolYear> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasValueGenerator<GuidValueGenerator>();
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasColumnName("created_at");
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");
            builder.Property(x => x.ClientSchoolKey).HasColumnName("client_school_key");

            //Entity columns
            builder.Property(x => x.Year).HasColumnName("year").IsRequired();
            builder.Property(x => x.Description).HasColumnName("description").IsRequired(false);
            builder.Property(x => x.Budget).HasColumnName("budget");
            builder.Property(x => x.Billing).HasColumnName("billing");

            builder.ToTable("School_Year");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
