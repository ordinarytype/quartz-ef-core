public class SysSchedulerStateConfiguration : IEntityTypeConfiguration<SysSchedulerState>
{
    public void Configure(EntityTypeBuilder<SysSchedulerState> entity)
    {
        // table name
        entity.ToTable("sys_scheduler_state");

        // primary key
        entity.HasKey(e => new { e.ScheduleName, e.InstanceName }).HasName("pk_sys_scheduler_state");

        // properties options
        entity.Property(e => e.ScheduleName).HasColumnName("sched_name").HasMaxLength(120).IsRequired();

        entity.Property(e => e.InstanceName).HasColumnName("instance_name").HasMaxLength(200).IsRequired();

        entity.Property(e => e.LastCheckinTime).HasColumnName("last_checkin_time").IsRequired();

        entity.Property(e => e.CheckinInterval).HasColumnName("checkin_interval").IsRequired();
    }
}