public class SysCronTriggerConfiguration : IEntityTypeConfiguration<SysCronTrigger>
{
    public void Configure(EntityTypeBuilder<SysCronTrigger> entity)
    {
        // table name
        entity.ToTable("sys_cron_triggers");

        // primary Key
        entity.HasKey(e => new { e.ScheduleName, e.TriggerName, e.TriggerGroup }).HasName("pk_sys_cron_triggers");

        // properties options
        entity.Property(e => e.ScheduleName).HasColumnName("sched_name").HasMaxLength(120).IsRequired();

        entity.Property(e => e.TriggerName).HasColumnName("trigger_name").HasMaxLength(150).IsRequired();

        entity.Property(e => e.TriggerGroup).HasColumnName("trigger_group").HasMaxLength(150).IsRequired();

        entity.Property(e => e.CronExpression).HasColumnName("cron_expression").HasMaxLength(120).IsRequired();

        entity.Property(e => e.TimeZoneId).HasColumnName("time_zone_id").HasMaxLength(80);

        // foreign keys
        entity.HasOne(d => d.Trigger)
            .WithOne(p => p.CronTrigger)
            .HasForeignKey<SysCronTrigger>(d => new { d.ScheduleName, d.TriggerName, d.TriggerGroup })
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("fk_sys_cron_triggers_sys_triggers");
    }
}