namespace MeetingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Main funcitionality of this app is needed, code below is only for testing various methods
            #region Testing field (temporary region)
            var meetings = new List<Meeting>();
            var person1 = new Person(1, "Simonas", "Pranaitis");
            var person2 = new Person(2, "Jonas", "Jonaitis");
            var person3 = new Person(3, "Algimantas", "Algimantaitis");

            var meeting1 = MainCommands.CreateMeeting("Mano meet'as", "Ivadinis", person1, "Hub", "Live", "2023-03-07", "2023-03-08");
            meetings.Add(meeting1);
            MainCommands.AddParticipant(meeting1, person2);
            MainCommands.AddParticipant(meeting1, person3);
            MainCommands.DisplayFullInfo(meeting1);

            var meeting2 = MainCommands.CreateMeeting("Antras meet'as", "Startinis", person1, "Hub", "Live", "2023-03-09", "2023-03-10");
            meetings.Add(meeting2);
            MainCommands.AddParticipant(meeting2, person2);
            MainCommands.AddParticipant(meeting2, person3);
            MainCommands.DisplayFullInfo(meeting2);

            MainCommands.AddParticipant(meeting2, person1);
            #endregion
        }
    }
}