using Newtonsoft.Json;

namespace MeetingApp
{
    internal static class MainCommands
    {
        /// <summary>
        /// Creates a new Meeting (unfinished)
        /// </summary>
        internal static void CreateMeeting()
        {
            new Meeting("Intro", "Introductory meeting", "Jonas", "Short", "Live", "2023-10-01", "2023-10-02");
        }
/// <summary>
/// Deletes meeting from meeting list and file
/// </summary>
/// <param name="meetings">Meeting list from witch a single meeting will be removed</param>
/// <param name="meeting">A specific meeting to be removed</param>
        internal static void DeleteMeeting(List<Meeting> meetings, Meeting meeting) 
        {
                meetings.Remove(meetings.FirstOrDefault(meeting));
        }
        /// <summary>
        /// Removes a participant from a specific meeting
        /// </summary>
        /// <param name="meeting">Specific meeting from witch a participant will be removed</param>
        /// <param name="memeber">Participant to be removed</param>
        internal static void RemoveParticipant(Meeting meeting, string memeber)
        {
            meeting._participants.Remove(meeting._participants.FirstOrDefault(memeber));
        }
        /// <summary>
        /// Displays a full info of a particular meeting
        /// </summary>
        /// <param name="meeting">Specific meeting, who's info is to be displayed</param>
        internal static void DisplayFullInfo(Meeting meeting)
        {
            Console.WriteLine("Meeting name: " + meeting.Name);
            Console.WriteLine("Meeting Description: " + meeting.Description);
            Console.WriteLine("Meeting Responsible person: " + meeting.ResponsiblePerson);
            Console.WriteLine("Meeting Category: " + meeting.Category);
            Console.WriteLine("Meeting Type: " + meeting.Type);
            Console.WriteLine("Meeting Start date: " + meeting.StartDate);
            Console.WriteLine("Meeting End date: " + meeting.EndDate);
            DisplayParticipants(meeting);
        }
        /// <summary>
        /// Saves a meeting to JSON file
        /// </summary>
        /// <param name="meeting">Specific meeting, who's data will be saved</param>
        internal static void SaveData(Meeting meeting)
        {
            string json = JsonConvert.SerializeObject(meeting, Formatting.Indented);
            File.WriteAllText("meeting.json", json);
        }
        /// <summary>
        /// Displays all members of a meeting
        /// </summary>
        internal static void DisplayParticipants(Meeting meeting)
        {
            Console.WriteLine("Members of the meeting:");
            for (var i = 0; i < meeting._participants.Count; i++)
                Console.WriteLine(meeting._participants[i]);
        }
        /// <summary>
        /// Adds a person to the participants of that meeting
        /// </summary>
        /// <param name="meeting">A meeting, to witch a participant will be added</param>
        /// <param name="member">A person, who will be added to the participants list</param>
        internal static void AddParticipant(Meeting meeting, string member)
        {
            meeting._participants.Add(member);
        }
    }
}
