namespace Xc.HiKVisionSdk.Isc.Events.Acs.Dtos
{
    public class MonitorDoorListChangedEventDto
    {
        public EventType Type { get; set; }
        public MonitorDoorListItemDto[] Items { get; set; }
    }
}
