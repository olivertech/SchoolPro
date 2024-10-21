namespace SchoolPro.Infra.EntityConfigurations
{
    public class FeatureRoleConfiguration : IEntityTypeConfiguration<FeatureRole>
    {
        public void Configure(EntityTypeBuilder<FeatureRole> builder)
        {
            //Common columns
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.SchoolKey).HasColumnName("client_school_key");

            //Entity columns
            builder.HasKey(x => new { x.FeatureId, x.RoleId});

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
