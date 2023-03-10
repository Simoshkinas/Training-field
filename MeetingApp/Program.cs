namespace MeetingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meetings = new List<Meeting>();
            // Main funcitionality of this app is unfinished
            #region Testing field (temporary region)
            //Message to be displayed when starting an app
            MainCommands.GiveGreeting();
            //Gives choises for the user
            MainCommands.DisplayStartingChoises();
            //Reads user input
            var userChoise = MainCommands.GetChoice(Console.ReadLine().ToUpper());

            switch (userChoise) 
            {
                case "A":
                    //Unfinished section
                    Console.WriteLine("Enter name of the meeting: ");
                    var name = MainCommands.GatherInput(Console.ReadLine());
                    Console.WriteLine($"Name of this meeting: {name}");
                    Console.WriteLine();
                    Console.WriteLine("Enter responsible person:");
                    Console.Write("Enter ID: ");
                    var id = MainCommands.GetId();
                    Console.WriteLine($"Your ID: {id}");
                    Console.WriteLine();
                    Console.Write("Enter your First Name: ");
                    var firstName = MainCommands.GatherInput(Console.ReadLine());
                    Console.Write("Enter your Last Name: ");
                    var lastName = MainCommands.GatherInput(Console.ReadLine());
                    Console.WriteLine($"Responsible person is: {firstName} {lastName}");
                    Console.WriteLine();
                    var responsiblePerson = new Person(id, firstName, lastName);
                    Console.Write("Enter description of this meeting:");
                    var description = MainCommands.GatherInput(Console.ReadLine());
                    Console.WriteLine($"Description: {description}");
                    Console.WriteLine();
                    Console.WriteLine("Choose the following Category: ");
                    Console.Write("A: CodeMonkey; B: Hub; C: Short; D: TeamBuilding; ");
                    var category = MainCommands.GetCategory(MainCommands.GetChoice(Console.ReadLine().ToUpper())); 
                    Console.WriteLine($"Meeting category:{category}");
                    Console.WriteLine();
                    Console.WriteLine("Choose the following meeting Type: ");
                    Console.Write("A: Live; B: InPerson;");
                    var type = MainCommands.GetType(Console.ReadLine().ToUpper());
                    Console.WriteLine($"Meeting type: {type}");
                    Console.WriteLine();
                    Console.WriteLine("Set start date, and end date of the meeting:");
                    var startDate = MainCommands.GetDateTime("Enter start date (MM/dd/yyyy hh:mm:ss): ");
                    var endDate = MainCommands.GetDateTime("Enter end date (MM/dd/yyyy hh:mm:ss): ");
                    Console.WriteLine($"Meting start date: {startDate}, end date: {endDate}");
                    Console.WriteLine();

                    var meeting = new Meeting(name, description, responsiblePerson, category, type, startDate, endDate );
                    meetings.Add(meeting);
                    break;
            }
            MainCommands.DisplayFullInfo(meetings[0]);
            //var person1 = new Person(1, "Simonas", "Pranaitis");
            //var person2 = new Person(2, "Jonas", "Jonaitis");
            //var person3 = new Person(3, "Algimantas", "Algimantaitis");

            //var meeting1 = MainCommands.CreateMeeting("Mano meet'as", "Ivadinis", person1, "Hub", "Live", "2023-03-07", "2023-03-08");
            //meetings.Add(meeting1);
            //MainCommands.AddParticipant(meeting1, person2);
            //MainCommands.AddParticipant(meeting1, person3);
            //MainCommands.DisplayFullInfo(meeting1);

            //var meeting2 = MainCommands.CreateMeeting("Antras meet'as", "Startinis", person1, "Hub", "Live", "2023-03-09", "2023-03-10");
            //meetings.Add(meeting2);
            //MainCommands.AddParticipant(meeting2, person2);
            //MainCommands.AddParticipant(meeting2, person3);
            //MainCommands.DisplayFullInfo(meeting2);

            //MainCommands.AddParticipant(meeting2, person1);
            #endregion
        }
    }
}