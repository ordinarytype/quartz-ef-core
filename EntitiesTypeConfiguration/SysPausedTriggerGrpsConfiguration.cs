public class SysPausedTriggerGrpsConfiguration : IEntityTypeConfiguration<SysPausedTriggerGrps>
{
    public void Configure(EntityTypeBuilder<SysPausedTriggerGrps> entity)
    {
        // table name
        entity.ToTable("sys_paused_trigger_grps");

        // primary key
        entity.HasKey(e => new { e.ScheduleName, e.TriggerGroup }).HasName("pk_sys_paused_trigger_grps");

        // properties options
        entity.Property(e => e.ScheduleName).HasColumnName("sched_name").HasMaxLength(120).IsRequired();

        entity.Property(e => e.TriggerGroup).HasColumnName("trigger_group").HasMaxLength(150).IsRequired();
    }
}