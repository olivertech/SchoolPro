namespace SchoolPro.Infra.EntityConfigurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            //Common columns
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.SchoolKey).HasColumnName("client_school_key");

            //Entity columns
            builder.HasKey(x => new { x.UserId, x.RoleId});

            //Relationship One-To-Many
            builder.HasOne(x => x.Role)
                   .WithMany(x => x.UserRoles)
                   .HasForeignKey(sp => sp.RoleId).HasConstraintName("role_id");

            builder.HasOne(sp => sp.User)
                   .WithMany(p => p.UserRoles)
                   .HasForeignKey(sp => sp.UserId).HasConstraintName("user_id");

            builder.Property(o => o.UserId)
                   .HasColumnName("user_id");

            builder.Property(o => o.RoleId)
                  .HasColumnName("role_id");

            builder.ToTable("User_Role");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
