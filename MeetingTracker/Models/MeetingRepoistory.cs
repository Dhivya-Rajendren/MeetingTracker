namespace MeetingTracker.Models
{
    public class MeetingRepoistory : IMeetingRepoistory
    {
        List<Meeting> meetingList = new List<Meeting>()
        {
            new Meeting(){MeetingId=1,MeetingType="Conference",MeetingName="Conference on Angular 14",RoomName="May Hall",MeetingDateTime=new DateTime(2022,07,12,10,00,00)},
         new Meeting() { MeetingId = 2,MeetingType = "Webniar",MeetingName = "Webinar on .Net Core 6",RoomName = "Arizona",MeetingDateTime = new DateTime(2022, 07, 21, 13, 00, 00)}
        };
         public Meeting GetMeeting(int id)
        {
            var meeting = meetingList.Find(x => x.MeetingId == id);
            return meeting;
        }

        public List<Meeting> GetMeetings()
        {
            return meetingList;
        }

        public User GetUser(string username,string password)
        {
            User user = new User() { UserName = "DhivyaCK", Password = "pass1", FirstName = "Dhivya", Role = "Admin" };
            if (user.UserName.Equals(username )&& user.Password.Equals(password))
            {
                return user;
            }
            else
            {
                return null;
            }
;
        }
    }
}
