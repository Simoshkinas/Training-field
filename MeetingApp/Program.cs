namespace MeetingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var programRun = true;
            var meetings = new List<Meeting>();
            //Message to be displayed when starting an app
            MainCommands.GiveGreeting();
            //Gives choises for the user
            do
            {
                // Main funcitionality of this app is unfinished
                MainCommands.DisplayStartingChoises();
                //Reads user input
                var userChoise = MainCommands.GetChoice(Console.ReadLine().ToUpper());

                switch (userChoise)
                {
                    case "A":
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
                        var meeting = new Meeting(name, description, responsiblePerson, category, type, startDate, endDate);
                        meetings.Add(meeting);
                        break;
                    case "B":
                        //Delete a meeting
                        MainCommands.DisplayAllMeetings(meetings);
                        Console.WriteLine();
                        Console.Write("Enter name of the meeting you want to delete:");
                        var deletableMeetingName = MainCommands.GatherInput(Console.ReadLine());
                        Console.WriteLine($"Meeting to be deleted: {deletableMeetingName}");
                        var deletableMeeting = meetings.FirstOrDefault(o => o.Name == deletableMeetingName);
                        Console.WriteLine();
                        Console.Write("Enter person ID, who isd responsible for this meeting:");
                        var responsibleId = MainCommands.GetId();
                        var resPerson = MainCommands.GetResponsiblePersonById(deletableMeeting, responsibleId);
                        Console.WriteLine($"Responsible person: {resPerson.FirstName} {resPerson.LastName}");
                        Console.Write("Delete this meeting? Y 'Yes'/N 'No':");
                        var userChoice2 = MainCommands.GetYesNo();
                        if (userChoice2 == "Y")
                            MainCommands.DeleteMeeting(meetings, deletableMeeting, resPerson);
                        Console.WriteLine();
                        Console.WriteLine($"Meeting {deletableMeeting.Name} has been deleted from list.");
                        break;
                    case "C":
                        //Add person to a meeting
                        MainCommands.DisplayAllMeetings(meetings);
                        Console.WriteLine();
                        Console.Write("Choose a meeting to which you would like to add a participant (enter name): ");
                        var addParticipantMeetingName = MainCommands.GatherInput(Console.ReadLine());
                        Console.WriteLine($"Chosen meeting: {addParticipantMeetingName}");
                        Console.WriteLine();
                        /*
                         
                         Command should specify who is being added and at what time.
                         If a person is already in a meeting which intersects with the one being added,
                         a warning message should be given.
                         Prevent the same person from being added twice

                        */
                        break;
                    case "D":
                        //List all meetings
                        /*
                         Filter by description (if the description is “Jono .NET meetas”, searching for
                         .NET should return this entry)
                         Filter by responsible person
                         Filter by category
                         Filter by type
                         Filter by dates (e.g meetings that will happen starting from 2022-01-01 /
                         meetings that will happen between 2022-01-01 and 2022-02-01)
                         Filter by the number of attendees (e.g show meetings that have over 10
                         people attending)
                        */
                        break;
                    case "E":
                        //Exit application
                        Console.WriteLine("Thank you for using this app. Have a nice day!");
                        programRun = false;
                        break;
                }

            }
            while (programRun);
        }
    }
}