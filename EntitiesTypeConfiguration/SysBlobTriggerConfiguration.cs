public class SysBlobTriggerConfiguration : IEntityTypeConfiguration<SysBlobTrigger>
{
    public void Configure(EntityTypeBuilder<SysBlobTrigger> entity)
    {
        // table name
        entity.ToTable("sys_blob_triggers");

        // primary key
        entity.HasKey(e => new { e.ScheduleName, e.TriggerName, e.TriggerGroup }).HasName("pk_sys_blob_triggers");

        // properties options
        entity.Property(e => e.ScheduleName).HasColumnName("sched_name").HasMaxLength(120).IsRequired();

        entity.Property(e => e.TriggerName).HasColumnName("trigger_name").HasMaxLength(150).IsRequired();

        entity.Property(e => e.TriggerGroup).HasColumnName("trigger_group").HasMaxLength(150).IsRequired();

        entity.Property(e => e.BlobData).HasColumnName("blob_data");
    }
}