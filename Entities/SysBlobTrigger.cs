public class SysBlobTrigger
{
    public string ScheduleName { get; set; }

    public string TriggerName { get; set; }

    public string TriggerGroup { get; set; }

    public byte[] BlobData { get; set; }
}