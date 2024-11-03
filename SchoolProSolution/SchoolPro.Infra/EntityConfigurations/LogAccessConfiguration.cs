namespace SchoolPro.Infra.EntityConfigurations
{
    public class LogAccessConfiguration : IEntityTypeConfiguration<LogAccess>
    {
        public void Configure(EntityTypeBuilder<LogAccess> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasValueGenerator<GuidValueGenerator>();
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasColumnName("created_at").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");
            //builder.Property(x => x.ClientSchoolKey).HasColumnName("client_school_key").IsRequired();

            //Entity columns
            builder.Property(x => x.UserId).HasColumnName("user_id").IsRequired();
            builder.Property(x => x.TimedAt).HasColumnName("timed_at").IsRequired();

            builder.ToTable("Log_Access");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
