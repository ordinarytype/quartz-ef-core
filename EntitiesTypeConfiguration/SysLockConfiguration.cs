public class SysLockConfiguration : IEntityTypeConfiguration<SysLock>
{
    public void Configure(EntityTypeBuilder<SysLock> entity)
    {
        // table name
        entity.ToTable("sys_locks");

        // primary key
        entity.HasKey(e => new { e.ScheduleName, e.LockName }).HasName("pk_sys_locks");

        // properties options
        entity.Property(e => e.ScheduleName).HasColumnName("sched_name").HasMaxLength(120).IsRequired();

        entity.Property(e => e.LockName).HasColumnName("lock_name").HasMaxLength(40).IsRequired();
    }
}