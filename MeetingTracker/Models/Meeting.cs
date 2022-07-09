namespace MeetingTracker.Models
{
    public class Meeting
    {
        public int MeetingId { get; set; }
        public string MeetingName { get; set; }
        public string RoomName { get; set; }
        public string MeetingType { get; set; }
        public DateTime MeetingDateTime { get; set; }
    }
}
