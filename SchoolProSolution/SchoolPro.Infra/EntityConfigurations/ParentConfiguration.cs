namespace SchoolPro.Infra.EntityConfigurations
{
    public class ParentConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
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
            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Birthdate).HasColumnName("birthdate").IsRequired(false);
            builder.Property(x => x.Gender).HasColumnName("gender").HasMaxLength(1).IsRequired(false);
            builder.Property(x => x.Kinship).HasColumnName("kinship").HasMaxLength(50).IsRequired();
            builder.Property(x => x.AddressId).HasColumnName("address_id");

            //Relationship One-To-Many
            builder.HasMany(d => d.Documents)
                .WithOne(d => d.Parent)
                .HasForeignKey(d => d.ParentId).HasConstraintName("parent_Id");

            builder.ToTable("Parent");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
