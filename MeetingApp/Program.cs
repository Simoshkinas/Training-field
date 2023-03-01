namespace MeetingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meetings = new List<Meeting>();

            
        }

        internal static Meeting CreateMeeting()
        {
            var meeting = new Meeting("Intro", "Introductory meeting", "Jonas", "Short", "Live", "2023-10-01", "2023-10-02");
            return meeting;
        }
        internal static void DisplayFullInfo(Meeting meeting)
        {
            Console.WriteLine("Meeting name: " + meeting.Name);
            Console.WriteLine("Meeting Description: " + meeting.Description);
            Console.WriteLine("Meeting Responsible person: " + meeting.ResponsiblePerson);
            Console.WriteLine("Meeting Category: " + meeting.Category);
            Console.WriteLine("Meeting Type: " + meeting.Type);
            Console.WriteLine("Meeting Start date: " + meeting.StartDate);
            Console.WriteLine("Meeting End date: " + meeting.EndDate);
            Console.WriteLine("Meeting members:");
            meeting.DisplayParticipants();
        }
    }
}