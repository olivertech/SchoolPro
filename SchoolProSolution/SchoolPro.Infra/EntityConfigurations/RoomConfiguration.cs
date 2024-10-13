namespace SchoolPro.Infra.EntityConfigurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasColumnName("created_at");
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");

            //Entity columns
            builder.Property(x => x.Id).HasColumnName("Id").HasValueGenerator<GuidValueGenerator>();

            builder.ToTable("Room");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
