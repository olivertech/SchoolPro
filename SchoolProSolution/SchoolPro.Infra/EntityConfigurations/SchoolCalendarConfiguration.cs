namespace SchoolPro.Infra.EntityConfigurations
{
    public class SchoolCalendarConfiguration : IEntityTypeConfiguration<SchoolCalendar>
    {
        public void Configure(EntityTypeBuilder<SchoolCalendar> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasValueGenerator<GuidValueGenerator>();
            builder.Property(x => x.CreatedAt).HasColumnName("created_at").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.ClientSchoolKey).HasColumnName("client_school_key").IsRequired();

            //Entity columns
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.Date).HasColumnName("date").IsRequired();
            builder.Property(x => x.TimeFrom).HasColumnName("time_from").IsRequired();
            builder.Property(x => x.TimeTo).HasColumnName("time_to").IsRequired();
            builder.Property(x => x.RoomId).HasColumnName("room_id");
            builder.Property(x => x.SchoolSubjectId).HasColumnName("school_subject_id");
            builder.Property(x => x.SchoolYearId).HasColumnName("school_year_id");

            builder.ToTable("School_Calendar");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
