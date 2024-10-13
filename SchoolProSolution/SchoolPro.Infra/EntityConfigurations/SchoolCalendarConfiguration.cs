namespace SchoolPro.Infra.EntityConfigurations
{
    public class SchoolCalendarConfiguration : IEntityTypeConfiguration<SchoolCalendar>
    {
        public void Configure(EntityTypeBuilder<SchoolCalendar> builder)
        {
            //Common columns
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.SchoolKey).HasColumnName("school_key");

            //Entity columns
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.Date).HasColumnName("date").IsRequired();
            builder.Property(x => x.TimeFrom).HasColumnName("time_from").IsRequired();
            builder.Property(x => x.TimeTo).HasColumnName("time_to").IsRequired();

            builder.Property(x => x.RoomId).HasColumnName("room_id");
            builder.Property(x => x.SchoolSubjectId).HasColumnName("school_subject_id");

            builder.HasKey(x => new { x.RoomId, x.SchoolSubjectId });

            builder.ToTable("School_Calendar");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
