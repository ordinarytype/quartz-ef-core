﻿public class SysTrigger
{
    public string ScheduleName { get; set; }

    public string TriggerName { get; set; }

    public string TriggerGroup { get; set; }

    public string JobName { get; set; }

    public string JobGroup { get; set; }

    public string Description { get; set; }

    public long? NextFireTime { get; set; }

    public long? PrevFireTime { get; set; }

    public int? Priority { get; set; }

    public string TriggerState { get; set; }

    public string TriggerType { get; set; }

    public long StartTime { get; set; }

    public long? EndTime { get; set; }

    public string CalendarName { get; set; }

    public int? MisfireInstr { get; set; }

    public byte[] JobData { get; set; }

    public SysCronTrigger CronTrigger { get; set; }

    public SysJobDetail JobDetail { get; set; }

    public SysSimpleTrigger SimpleTrigger { get; set; }

    public SysSimpropTrigger SimpropTrigger { get; set; }
}