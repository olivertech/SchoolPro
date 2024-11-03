namespace SchoolPro.Infra.EntityConfigurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
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
            builder.Property(x => x.ResponsableName).HasColumnName("responsable_name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.ResponsableEmail).HasColumnName("responsable_email").HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.ResponsableCellPhone1).HasColumnName("responsable_cellphone_1").HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.ResponsableCellPhone2).HasColumnName("responsable_cellphone_2").HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.ClientKey).HasColumnName("client_key").IsRequired().HasValueGenerator<GuidValueGenerator>();

            builder.ToTable("Client");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);

            builder.HasData(new[]
            {
                new Client
                {
                    Id = Guid.Parse("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                    Name = "Rede de Ensino 123 de Oliveira 4",
                    Description = "Rede de Ensino 123 de Oliveira 4",
                    ResponsableName = "João da Silva",
                    ResponsableEmail = "joao.silva@123deoliveira4.com",
                    ResponsableCellPhone1 = "(11) 11111-1111",
                    ResponsableCellPhone2 = "(22) 22222-2222",
                    ClientKey = Guid.Parse("45533ff6-3ba5-11ef-9476-0242ac130002"),
                    CreatedAt = DateOnly.FromDateTime(DateTime.Now)
                },
            });
        }
    }
}
