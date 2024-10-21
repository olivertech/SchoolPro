﻿namespace SchoolPro.Infra.EntityConfigurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasColumnName("created_at");
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");

            builder.Property(x => x.Id).HasColumnName("id");

            //Entity columns
            builder.Property(x => x.Id).HasColumnName("Id").HasValueGenerator<GuidValueGenerator>();
            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.ResponsableName).HasColumnName("responsable_name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.ResponsableEmail).HasColumnName("responsable_email").HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.ResponsableCellPhone1).HasColumnName("responsable_cellphone_1").HasMaxLength(11).IsRequired(false);
            builder.Property(x => x.ResponsableCellPhone2).HasColumnName("responsable_cellphone_2").HasMaxLength(11).IsRequired(false);
            builder.Property(x => x.ClientKey).HasColumnName("client_key").HasValueGenerator<GuidValueGenerator>();

            builder.ToTable("Client");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}