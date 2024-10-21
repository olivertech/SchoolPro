namespace SchoolPro.Infra.EntityConfigurations
{
    public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
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
            builder.Property(x => x.MenuName).HasColumnName("menu_name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.MenuTip).HasColumnName("menu_tip").HasMaxLength(25).IsRequired();
            builder.Property(x => x.MenuEndPoint).HasColumnName("menu_endpoint").HasMaxLength(150).IsRequired();
            builder.Property(x => x.MenuIcon).HasColumnName("menu_icon").HasMaxLength(50).IsRequired();

            builder.ToTable("Feature");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
