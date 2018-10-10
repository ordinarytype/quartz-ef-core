public class SysSimpleTrigger
{
    public string ScheduleName { get; set; }

    public string TriggerName { get; set; }

    public string TriggerGroup { get; set; }

    public int RepeatCount { get; set; }

    public long RepeatInterval { get; set; }

    public int TimesTriggered { get; set; }

    public SysTrigger Trigger { get; set; }
}