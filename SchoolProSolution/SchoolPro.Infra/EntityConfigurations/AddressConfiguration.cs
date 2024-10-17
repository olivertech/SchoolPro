namespace SchoolPro.Infra.EntityConfigurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
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
            builder.Property(x => x.Telephone).HasColumnName("telephone").HasMaxLength(10).IsRequired(false);
            builder.Property(x => x.CellPhone).HasColumnName("cellphone").HasMaxLength(11).IsRequired(false);
            builder.Property(x => x.StreetAddress).HasColumnName("street_address").HasMaxLength(250).IsRequired();
            builder.Property(x => x.AddressLine2).HasColumnName("address_line_2").HasMaxLength(250);
            builder.Property(x => x.Neighborhood).HasColumnName("neighborhood").HasMaxLength(250);
            builder.Property(x => x.City).HasColumnName("city").HasMaxLength(250);
            builder.Property(x => x.State).HasColumnName("state").HasMaxLength(25);
            builder.Property(x => x.PostalCode).HasColumnName("postal_code").HasMaxLength(8);

            builder.ToTable("Address");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
