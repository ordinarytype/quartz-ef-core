public class SysFiredTriggerConfiguration : IEntityTypeConfiguration<SysFiredTrigger>
{
    public void Configure(EntityTypeBuilder<SysFiredTrigger> entity)
    {
        // table name
        entity.ToTable("sys_fired_triggers");

        // primary key
        entity.HasKey(t => new { t.ScheduleName, t.EntryId }).HasName("pk_sys_fired_triggers");

        // indexes
        entity.HasIndex(e => new { e.ScheduleName, e.InstanceName }).HasName("idx_sys_ft_trig_inst_name");

        entity.HasIndex(e => new { e.ScheduleName, e.InstanceName, e.RequestsRecovery })
            .HasName("idx_sys_ft_inst_job_req_rcvry");

        entity.HasIndex(e => new { e.ScheduleName, e.JobName, e.JobGroup }).HasName("idx_sys_ft_j_g");

        entity.HasIndex(e => new { e.ScheduleName, e.JobGroup }).HasName("idx_sys_ft_jg");

        entity.HasIndex(e => new { e.ScheduleName, e.TriggerName, e.TriggerGroup }).HasName("idx_sys_ft_t_g");

        entity.HasIndex(e => new { e.ScheduleName, e.TriggerGroup }).HasName("idx_sys_ft_tg");

        // properties options
        entity.Property(e => e.ScheduleName).HasColumnName("sched_name").HasMaxLength(120).IsRequired();

        entity.Property(e => e.EntryId).HasColumnName("entry_id").HasMaxLength(140).IsRequired();

        entity.Property(e => e.TriggerName).HasColumnName("trigger_name").HasMaxLength(150).IsRequired();

        entity.Property(e => e.TriggerGroup).HasColumnName("trigger_group").HasMaxLength(150).IsRequired();

        entity.Property(e => e.InstanceName).HasColumnName("instance_name").HasMaxLength(200).IsRequired();

        entity.Property(e => e.FiredTime).HasColumnName("fired_time").IsRequired();

        entity.Property(e => e.ScheduledTime).HasColumnName("sched_time").IsRequired();

        entity.Property(e => e.Priority).HasColumnName("priority").IsRequired();

        entity.Property(e => e.State).HasColumnName("state").HasMaxLength(16).IsRequired();

        entity.Property(e => e.JobName).HasColumnName("job_name").HasMaxLength(150);

        entity.Property(e => e.JobGroup).HasColumnName("job_group").HasMaxLength(150);

        entity.Property(e => e.IsNonconcurrent).HasColumnName("is_nonconcurrent");

        entity.Property(e => e.RequestsRecovery).HasColumnName("requests_recovery");
    }
}