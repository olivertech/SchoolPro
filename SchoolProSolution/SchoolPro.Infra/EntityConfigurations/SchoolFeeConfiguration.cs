namespace SchoolPro.Infra.EntityConfigurations
{
    public class SchoolFeeConfiguration : IEntityTypeConfiguration<SchoolFee>
    {
        public void Configure(EntityTypeBuilder<SchoolFee> builder)
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
            builder.Property(x => x.Value).HasColumnName("value").IsRequired();
            builder.Property(x => x.DueDate).HasColumnName("due_date");
            builder.Property(x => x.PaymentDate).HasColumnName("payment_date");
            builder.Property(x => x.StatusFee).HasColumnName("status_fee");
            builder.Property(x => x.SchoolEnrollmentId).HasColumnName("school_enrollment_id");
            builder.Property(x => x.DocumentId).HasColumnName("document_id");
            builder.Property(x => x.FeeTypeId).HasColumnName("fee_type_id");

            builder.ToTable("School_Fee");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
