using Newtonsoft.Json;
using System;
using System.Text.Json;
namespace MeetingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meetings = new List<Meeting>();


            
        }
        /// <summary>
        /// Creates a new Meeting
        /// </summary>
        internal static void CreateMeeting()
        {
            var meeting = new Meeting("Intro", "Introductory meeting", "Jonas", "Short", "Live", "2023-10-01", "2023-10-02");
            SaveData(meeting);
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
            meeting.DisplayParticipants();
        }
        /// <summary>
        /// Saves a meeting to JSON file
        /// </summary>
        /// <param name="meeting">Specific meeting, who's data will be saved</param>
        internal static void SaveData(Meeting meeting) 
        {
            string json = JsonConvert.SerializeObject(meeting, Formatting.Indented);
            File.WriteAllText("person.json", json);
        }
    }
}