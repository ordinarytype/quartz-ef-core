public class SysSchedulerState
{
    public string ScheduleName { get; set; }

    public string InstanceName { get; set; }

    public long LastCheckinTime { get; set; }

    public long CheckinInterval { get; set; }
}