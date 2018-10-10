public class SysSimpleTriggerConfiguration : IEntityTypeConfiguration<SysSimpleTrigger>
{
    public void Configure(EntityTypeBuilder<SysSimpleTrigger> entity)
    {
        // table name
        entity.ToTable("sys_simple_triggers");

        // primary key
        entity.HasKey(e => new { e.ScheduleName, e.TriggerName, e.TriggerGroup }).HasName("pk_sys_simple_triggers");

        // properties options
        entity.Property(e => e.ScheduleName).HasColumnName("sched_name").HasMaxLength(120).IsRequired();

        entity.Property(e => e.TriggerName).HasColumnName("trigger_name").HasMaxLength(150).IsRequired();

        entity.Property(e => e.TriggerGroup).HasColumnName("trigger_group").HasMaxLength(150).IsRequired();

        entity.Property(e => e.RepeatCount).HasColumnName("repeat_count").IsRequired();

        entity.Property(e => e.RepeatInterval).HasColumnName("repeat_interval").IsRequired();

        entity.Property(e => e.TimesTriggered).HasColumnName("times_triggered").IsRequired();

        //foreign keys
        entity.HasOne(d => d.Trigger)
            .WithOne(p => p.SimpleTrigger)
            .HasForeignKey<SysSimpleTrigger>(d => new { d.ScheduleName, d.TriggerName, d.TriggerGroup })
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("fk_sys_simple_triggers_sys_triggers");
    }
}