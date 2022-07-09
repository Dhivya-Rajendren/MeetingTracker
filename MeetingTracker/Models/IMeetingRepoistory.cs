namespace MeetingTracker.Models
{
    public interface IMeetingRepoistory
    {

        List<Meeting> GetMeetings();
        Meeting GetMeeting(int id); 

        User GetUser(string username,string password);
    }
}
