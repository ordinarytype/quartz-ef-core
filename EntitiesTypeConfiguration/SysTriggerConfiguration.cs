public class SysTriggerConfiguration : IEntityTypeConfiguration<SysTrigger>
{
    public void Configure(EntityTypeBuilder<SysTrigger> entity)
    {
        // table name
        entity.ToTable("sys_triggers");

        // primary key
        entity.HasKey(e => new { e.ScheduleName, e.TriggerName, e.TriggerGroup }).HasName("pk_sys_triggers");

        // indexes
        entity.HasIndex(e => new { e.ScheduleName, e.JobName, e.JobGroup }).HasName("idx_sys_t_j");

        entity.HasIndex(e => new { e.ScheduleName, e.JobGroup }).HasName("idx_sys_t_jg");

        entity.HasIndex(e => new { e.ScheduleName, e.CalendarName }).HasName("idx_sys_t_c");

        entity.HasIndex(e => new { e.ScheduleName, e.TriggerGroup }).HasName("idx_sys_t_g");

        entity.HasIndex(e => new { e.ScheduleName, e.TriggerState }).HasName("idx_sys_t_state");

        entity.HasIndex(e => new { e.ScheduleName, e.TriggerName, e.TriggerGroup, e.TriggerState })
            .HasName("idx_sys_t_n_state");

        entity.HasIndex(e => new { e.ScheduleName, e.TriggerGroup, e.TriggerState }).HasName("idx_sys_t_n_g_state");

        entity.HasIndex(e => new { e.ScheduleName, e.NextFireTime }).HasName("idx_sys_t_next_fire_time");

        entity.HasIndex(e => new { e.ScheduleName, e.TriggerState, e.NextFireTime }).HasName("idx_sys_t_nft_st");

        entity.HasIndex(e => new { e.ScheduleName, e.MisfireInstr, e.NextFireTime }).HasName("idx_sys_t_nft_misfire");

        entity.HasIndex(e => new { e.ScheduleName, e.MisfireInstr, e.NextFireTime, e.TriggerState })
            .HasName("idx_sys_t_nft_st_misfire");

        entity.HasIndex(e => new { e.ScheduleName, e.MisfireInstr, e.NextFireTime, e.TriggerGroup, e.TriggerState })
            .HasName("idx_sys_t_nft_st_misfire_grp");

        // properties options
        entity.Property(e => e.ScheduleName).HasColumnName("sched_name").HasMaxLength(120).IsRequired();

        entity.Property(e => e.TriggerName).HasColumnName("trigger_name").HasMaxLength(150).IsRequired();

        entity.Property(e => e.TriggerGroup).HasColumnName("trigger_group").HasMaxLength(150).IsRequired();

        entity.Property(e => e.JobName).HasColumnName("job_name").HasMaxLength(150).IsRequired();

        entity.Property(e => e.JobGroup).HasColumnName("job_group").HasMaxLength(150).IsRequired();

        entity.Property(e => e.Description).HasColumnName("description").HasMaxLength(250);

        entity.Property(e => e.NextFireTime).HasColumnName("next_fire_time");

        entity.Property(e => e.PrevFireTime).HasColumnName("prev_fire_time");

        entity.Property(e => e.Priority).HasColumnName("priority");

        entity.Property(e => e.TriggerState).HasColumnName("trigger_state").HasMaxLength(16).IsRequired();

        entity.Property(e => e.TriggerType).HasColumnName("trigger_type").HasMaxLength(8).IsRequired();

        entity.Property(e => e.StartTime).HasColumnName("start_time").IsRequired();

        entity.Property(e => e.EndTime).HasColumnName("end_time");

        entity.Property(e => e.CalendarName).HasColumnName("calendar_name").HasMaxLength(200);

        entity.Property(e => e.MisfireInstr).HasColumnName("misfire_instr");

        entity.Property(e => e.JobData).HasColumnName("job_data");

        // foreign keys
        entity.HasOne(d => d.JobDetail)
            .WithMany(p => p.Triggers)
            .HasForeignKey(d => new { d.ScheduleName, d.JobName, d.JobGroup })
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("fk_sys_triggers_sys_job_details");
    }
}