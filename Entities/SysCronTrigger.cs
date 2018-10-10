public class SysCronTrigger
{
    public string ScheduleName { get; set; }

    public string TriggerName { get; set; }

    public string TriggerGroup { get; set; }

    public string CronExpression { get; set; }

    public string TimeZoneId { get; set; }

    public SysTrigger Trigger { get; set; }
}