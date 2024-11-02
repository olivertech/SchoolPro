namespace SchoolPro.Infra.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
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
            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Password).HasColumnName("password").HasMaxLength(10).IsRequired();
            builder.Property(x => x.Email).HasColumnName("email").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PicturePath).HasColumnName("picture_path").HasMaxLength(50).IsRequired();
            builder.Property(x => x.ClientId).HasColumnName("client_id");

            builder.ToTable("User");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
