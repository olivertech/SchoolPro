namespace SchoolPro.Infra.EntityConfigurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
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
            builder.Property(x => x.Telephone).HasColumnName("telephone").HasMaxLength(10).IsRequired(false);
            builder.Property(x => x.CellPhone).HasColumnName("cellphone").HasMaxLength(11).IsRequired(false);
            builder.Property(x => x.Email).HasColumnName("email").HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Facebook).HasColumnName("facebook").HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.Instagram).HasColumnName("instagram").HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.Twitter).HasColumnName("twitter").HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.LinkedIn).HasColumnName("linkedin").HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.Github).HasColumnName("github").HasMaxLength(11).IsRequired(false);
            builder.Property(x => x.StreetAddress).HasColumnName("street_address").HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.AddressLine2).HasColumnName("address_line_2").HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.Neighborhood).HasColumnName("neighborhood").HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.City).HasColumnName("city").HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.State).HasColumnName("state").HasMaxLength(25).IsRequired(false);
            builder.Property(x => x.PostalCode).HasColumnName("postal_code").HasMaxLength(8).IsRequired(false);

            builder.ToTable("Contact");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
