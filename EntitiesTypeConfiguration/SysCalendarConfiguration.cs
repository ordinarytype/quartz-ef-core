public class SysCalendarConfiguration : IEntityTypeConfiguration<SysCalendar>
{
    public void Configure(EntityTypeBuilder<SysCalendar> entity)
    {
        // table name
        entity.ToTable("sys_calendars");

        // primary key
        entity.HasKey(e => new { e.ScheduleName, e.CalendarName }).HasName("pk_sys_calendars");

        // properties options
        entity.Property(e => e.ScheduleName).HasColumnName("sched_name").HasMaxLength(120).IsRequired();

        entity.Property(e => e.CalendarName).HasColumnName("calendar_name").HasMaxLength(200).IsRequired();

        entity.Property(e => e.Calendar).HasColumnName("calendar").IsRequired();
    }
}