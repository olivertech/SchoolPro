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
            builder.Property(x => x.CreatedAt).HasColumnName("created_at").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");

            //Entity columns
            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.CNPJ).HasColumnName("cnpj").HasMaxLength(14).IsRequired();
            builder.Property(x => x.StateRegistration).HasColumnName("state_registration").HasMaxLength(25).IsRequired(false);
            builder.Property(x => x.CountyRegistration).HasColumnName("count_registration").HasMaxLength(25).IsRequired(false);
            builder.Property(x => x.IsBranch).HasColumnName("is_branch").IsRequired();
            builder.Property(x => x.ContactId).HasColumnName("contact_id").IsRequired(false);
            builder.Property(x => x.ClientId).HasColumnName("client_id").IsRequired();
            builder.Property(x => x.SchoolSecretKey).HasColumnName("school_secret_key").IsRequired().HasMaxLength(32);

            //Relationship One-To-Many
            builder.HasMany(d => d.Documents)
                .WithOne(d => d.School)
                .HasForeignKey(d => d.SchoolId).HasConstraintName("school_Id");

            builder.ToTable("School");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);

            builder.HasData(new[]
            {
                new School
                {
                    Id = Guid.Parse("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                    Name = "Matriz da Rede de Ensino 123 de Oliveira 4",
                    Description = "Matriz da Rede de Ensino 123 de Oliveira 4",
                    ClientId = Guid.Parse("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                    CNPJ = "12345678000199",
                    IsBranch = false,
                    SchoolSecretKey = "HejGkZngN6A2JzLQ2g5luuye8qSzhmg5",
                    IsActive = true,
                    CreatedAt = DateOnly.FromDateTime(DateTime.Now)
                },
            });
        }
    }
}
