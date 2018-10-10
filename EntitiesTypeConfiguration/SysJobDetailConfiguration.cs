public class SysJobDetailConfiguration : IEntityTypeConfiguration<SysJobDetail>
{
    public void Configure(EntityTypeBuilder<SysJobDetail> entity)
    {
        // table name
        entity.ToTable("sys_job_details");

        // primary key
        entity.HasKey(e => new { e.ScheduleName, e.JobName, e.JobGroup }).HasName("pk_sys_job_details");

        // properties options
        entity.Property(e => e.ScheduleName).HasColumnName("sched_name").HasMaxLength(120).IsRequired();

        entity.Property(e => e.JobName).HasColumnName("job_name").HasMaxLength(150).IsRequired();

        entity.Property(e => e.JobGroup).HasColumnName("job_group").HasMaxLength(150).IsRequired();

        entity.Property(e => e.Description).HasColumnName("description").HasMaxLength(250);

        entity.Property(e => e.JobClassName).HasColumnName("job_class_name").HasMaxLength(250).IsRequired();

        entity.Property(e => e.IsDurable).HasColumnName("is_durable").IsRequired();

        entity.Property(e => e.IsNonconcurrent).HasColumnName("is_nonconcurrent").IsRequired();

        entity.Property(e => e.IsUpdateData).HasColumnName("is_update_data").IsRequired();

        entity.Property(e => e.RequestsRecovery).HasColumnName("requests_recovery").IsRequired();

        entity.Property(e => e.JobData).HasColumnName("job_data");
    }
}