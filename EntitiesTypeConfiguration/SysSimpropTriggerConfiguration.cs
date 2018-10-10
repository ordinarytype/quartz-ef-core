public class SysSimpropTriggerConfiguration : IEntityTypeConfiguration<SysSimpropTrigger>
{
    public void Configure(EntityTypeBuilder<SysSimpropTrigger> entity)
    {
        // table name
        entity.ToTable("sys_simprop_triggers");

        // primary key
        entity.HasKey(e => new { e.ScheduleName, e.TriggerName, e.TriggerGroup }).HasName("pk_sys_simprop_triggers");

        // properties options
        entity.Property(e => e.ScheduleName).HasColumnName("sched_name").HasMaxLength(120).IsRequired();

        entity.Property(e => e.TriggerName).HasColumnName("trigger_name").HasMaxLength(150).IsRequired();

        entity.Property(e => e.TriggerGroup).HasColumnName("trigger_group").HasMaxLength(150).IsRequired();

        entity.Property(e => e.StrProp1).HasColumnName("str_prop_1").HasMaxLength(512);

        entity.Property(e => e.StrProp2).HasColumnName("str_prop_2").HasMaxLength(512);

        entity.Property(e => e.StrProp3).HasColumnName("str_prop_3").HasMaxLength(512);

        entity.Property(e => e.IntProp1).HasColumnName("int_prop_1");

        entity.Property(e => e.IntProp2).HasColumnName("int_prop_2");

        entity.Property(e => e.LongProp1).HasColumnName("long_prop_1");

        entity.Property(e => e.LongProp2).HasColumnName("long_prop_2");

        entity.Property(e => e.DecProp1).HasColumnType("numeric(13,4)").HasColumnName("dec_prop_1");

        entity.Property(e => e.DecProp2).HasColumnType("numeric(13,4)").HasColumnName("dec_prop_2");

        entity.Property(e => e.BoolProp1).HasColumnName("bool_prop_1");

        entity.Property(e => e.BoolProp2).HasColumnName("bool_prop_2");

        entity.Property(e => e.TimeZoneId).HasColumnName("time_zone_id").HasMaxLength(80);

        // foreign keys
        entity.HasOne(d => d.Trigger)
            .WithOne(p => p.SimpropTrigger)
            .HasForeignKey<SysSimpropTrigger>(d => new { d.ScheduleName, d.TriggerName, d.TriggerGroup })
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("fk_sys_simprop_triggers_sys_triggers");
    }
}