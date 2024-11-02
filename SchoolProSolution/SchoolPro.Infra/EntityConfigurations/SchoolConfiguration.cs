namespace SchoolPro.Infra.EntityConfigurations
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasValueGenerator<GuidValueGenerator>();
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasColumnName("created_at");
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");
            builder.Property(x => x.SchoolKey).HasColumnName("client_school_key");

            //Entity columns
            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.CNPJ).HasColumnName("cnpj").HasMaxLength(14).IsRequired();
            builder.Property(x => x.StateRegistration).HasColumnName("state_registration").HasMaxLength(25).IsRequired(false);
            builder.Property(x => x.CountyRegistration).HasColumnName("count_registration").HasMaxLength(25).IsRequired(false);
            builder.Property(x => x.IsBranch).HasColumnName("is_branch").IsRequired();
            builder.Property(x => x.ContactId).HasColumnName("contact_id");
            builder.Property(x => x.ClientId).HasColumnName("client_id");

            //Relationship One-To-Many
            builder.HasMany(d => d.Documents)
                .WithOne(d => d.School)
                .HasForeignKey(d => d.SchoolId).HasConstraintName("school_Id");

            builder.ToTable("School");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
