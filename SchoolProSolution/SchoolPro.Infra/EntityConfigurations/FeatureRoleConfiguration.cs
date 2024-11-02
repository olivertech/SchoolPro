namespace SchoolPro.Infra.EntityConfigurations
{
    public class FeatureRoleConfiguration : IEntityTypeConfiguration<FeatureRole>
    {
        public void Configure(EntityTypeBuilder<FeatureRole> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasValueGenerator<GuidValueGenerator>();
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.ClientSchoolKey).HasColumnName("client_school_key");

            //Relationship One-To-Many
            builder.HasOne(x => x.Role)
                   .WithMany(x => x.FeaturesRole)
                   .HasForeignKey(sp => sp.RoleId).HasConstraintName("role_id");

            builder.HasOne(sp => sp.Feature)
                   .WithMany(p => p.FeaturesRole)
                   .HasForeignKey(sp => sp.FeatureId).HasConstraintName("feature_id");

            builder.Property(o => o.FeatureId)
                   .HasColumnName("feature_id");

            builder.Property(o => o.RoleId)
                  .HasColumnName("role_id");

            builder.ToTable("Feature_Role");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
