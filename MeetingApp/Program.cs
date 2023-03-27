using Newtonsoft.Json;
using System.Text.Json;

namespace MeetingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var programRun = true;
            List<Meeting> ? meetings;
            var path = @"D:\meetingAppSaves\meetings.json";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                meetings = JsonConvert.DeserializeObject<List<Meeting>>(json);
            }
            else
            {
                meetings = new List<Meeting>();
            }
            //Message to be displayed when starting an app
            MainCommands.GiveGreeting();
            //Gives choises for the user
            do
            {
                // Main funcitionality of this app is unfinished
                MainCommands.DisplayStartingChoises();
                //Reads user input
                var userChoise = MainCommands.GetChoice(Console.ReadLine()?.ToUpper());

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
                        var category = MainCommands.GetCategory(MainCommands.GetChoice(Console.ReadLine()?.ToUpper()));
                        Console.WriteLine($"Meeting category:{category}");
                        Console.WriteLine();
                        Console.WriteLine("Choose the following meeting Type: ");
                        Console.Write("A: Live; B: InPerson;");
                        var type = MainCommands.GetType(Console.ReadLine()?.ToUpper());
                        Console.WriteLine($"Meeting type: {type}");
                        Console.WriteLine();
                        Console.WriteLine("Set start date, and end date of the meeting:");
                        var startDate = MainCommands.GetDateTime("Enter start date (MM/dd/yyyy hh:mm:ss): ");
                        var endDate = MainCommands.GetDateTime("Enter end date (MM/dd/yyyy hh:mm:ss): ");
                        Console.WriteLine($"Meting start date: {startDate}, end date: {endDate}");
                        Console.WriteLine();
                        var meeting = new Meeting(name, description, responsiblePerson, category, type, startDate, endDate);
                        meetings?.Add(meeting);
                        break;
                    case "B":
                        //Delete a meeting
                        MainCommands.DisplayAllMeetings(meetings);
                        Console.WriteLine();
                        Console.Write("Enter name of the meeting you want to delete:");
                        var deletableMeetingName = MainCommands.GatherInput(Console.ReadLine());
                        Console.WriteLine($"Meeting to be deleted: {deletableMeetingName}");
                        var deletableMeeting = meetings?.FirstOrDefault(meeting => meeting.Name == deletableMeetingName);
                        Console.WriteLine();
                        Console.Write("Enter person ID, who is responsible for this meeting:");
                        var responsibleId = MainCommands.GetId();
                        var resPerson = MainCommands.GetResponsiblePersonById(deletableMeeting, responsibleId);
                        Console.WriteLine($"Responsible person: {resPerson?.FirstName} {resPerson?.LastName}");
                        Console.Write("Delete this meeting? Y 'Yes'/N 'No':");
                        Console.WriteLine();
                        var userChoice2 = MainCommands.GetYesNo();
                        if (userChoice2 == "Y")
                        {
                            MainCommands.DeleteMeeting(meetings, deletableMeeting, resPerson);
                            Console.WriteLine($"Meeting {deletableMeeting?.Name} has been deleted from list.");
                        }
                        break;
                    case "C":
                        MainCommands.DisplayAllMeetings(meetings);
                        Console.WriteLine();
                        Console.Write("Choose a meeting to which you would like to edit (enter name): ");
                        var addParticipantMeetingName = MainCommands.GatherInput(Console.ReadLine());
                        var editedMeeting = meetings?.FirstOrDefault(meeting => meeting.Name == addParticipantMeetingName);
                        MainCommands.DisplayFullInfo(editedMeeting);
                        Console.WriteLine("Choose the following option from below.");
                        Console.WriteLine("'A' - Add person to a meeting; 'B' - Remove person from pas particular meeting;");
                        var userChoice3 = MainCommands.GetTwoChoices();
                        switch (userChoice3)
                        {
                            case "A":
                                {
                                    //Add person to a meeting
                                    Console.WriteLine();
                                    Console.Write("Enter person ID: ");
                                    var personId = MainCommands.GetId();
                                    Console.WriteLine($"Person ID: {personId}");
                                    Console.WriteLine();
                                    Console.Write("Enter first name: ");
                                    var personName = MainCommands.GatherInput(Console.ReadLine());
                                    Console.WriteLine($"First name: {personName}");
                                    Console.WriteLine();
                                    Console.WriteLine("Enter last name: ");
                                    var personSurname = MainCommands.GatherInput(Console.ReadLine());
                                    Console.WriteLine($"Last name: {personSurname}");
                                    Console.WriteLine();
                                    var date = MainCommands.GetDateTime("Enter date, from which this person will be added to the meeting: "); //a date, from which a person is being added
                                    var newParticipant = new Person(personId, personName, personSurname);
                                    MainCommands.AddParticipant(editedMeeting, newParticipant);
                                    Console.WriteLine($"{newParticipant?.FirstName} {newParticipant?.LastName} is added to a meeting: {editedMeeting}");
                                    break;
                                }
                            case "B":
                                //Remove participant from a meeting
                                {
                                    Console.WriteLine();
                                    Console.Write("Enter person ID: ");
                                    var personId = MainCommands.GetId();
                                    Console.WriteLine($"Person ID: {personId}");
                                    Console.WriteLine(); 
                                    MainCommands.RemoveParticipant(editedMeeting, editedMeeting?._participants.FirstOrDefault(participant => participant.Id == personId));
                                    break;
                                }
                        }   
                        //Unfinished
                        /*                         
                         Command should specify who is being added and at what time.
                        */
                        break;
                    case "D":
                        //List all meetings, unfinished
                        MainCommands.DisplayAllMeetings(meetings); //Temporary line, for testing purposes
                        Console.WriteLine("Choose the parameter you want to filter all meetings by:");
                        Console.WriteLine("A: Description; B: Responsible Person; C: Category; D: Type; E: Dates; F: Number of attendees;");
                        var userChoice4 = MainCommands.GetChoice3();
                        switch (userChoice4)
                        {
                            case "A":
                                {
                                    //Filter by description
                                    Console.Write("Enter meeting description: ");
                                    var filteredString = MainCommands.GatherInput(Console.ReadLine());
                                    //Main filter by description, move to main commands needed
                                    var filteredMeetings = meetings?.Where(o => o.Description.Contains(filteredString)).ToList(); 
                                    MainCommands.DisplayAllMeetings(filteredMeetings);
                                    break;
                                }
                            case "B":
                                {
                                    //Filter by Responsible person
                                    Console.Write("Enter responsible person ID: ");
                                    var filteredResponsiblePersonId = MainCommands.GetId();
                                    //Main filter by responsible person, move to main commands needed
                                    var filteredMeetings = meetings?.Where(o => o.ResponsiblePerson.Id.Equals(filteredResponsiblePersonId)).ToList();
                                    MainCommands.DisplayAllMeetings(filteredMeetings);
                                    break;
                                }
                            case "C":
                                {
                                    //Filter by category
                                    Console.Write("Enter meeting category: ");
                                    var filteredCategory = MainCommands.GetCategory(MainCommands.GetChoice2());
                                    //main filter by category, move to main commands needed
                                    var filteredMeetings = meetings?.Where(o => o.Category.Equals(filteredCategory)).ToList();
                                    MainCommands.DisplayAllMeetings(filteredMeetings);
                                    break;
                                }
                            case "D":
                                {
                                    //Filter by type
                                    Console.Write("Enter meeting type: ");
                                    var filteredType = MainCommands.GetType(MainCommands.GatherInput(Console.ReadLine()?.ToUpper()));
                                    //main filter by type, move to main commands needed
                                    var filteredMeetings = meetings?.Where(o => o.Type.Equals(filteredType)).ToList();
                                    MainCommands.DisplayAllMeetings(filteredMeetings);
                                    break;
                                }
                            case "E":
                                {
                                    //Filter by dates
                                    Console.WriteLine("Enter Date time range.");
                                    var filteredStartDate = MainCommands.GetDateTime("Enter start Date (MM/dd/yyyy hh:mm:ss): ");
                                    var filteredEndDate = MainCommands.GetDateTime("Enter end Date (MM/dd/yyyy hh:mm:ss): ");
                                    //main filter by date range, move to main commands needed
                                    var filteredMeetings = meetings?.Where(o => o.StartDate >= filteredStartDate && o.EndDate <= filteredEndDate).ToList();
                                    MainCommands.DisplayAllMeetings(filteredMeetings);
                                    break;
                                }
                            case "F":
                                {
                                    //Filter by number of attendees, not finished
                                    Console.WriteLine("Specifiy, how you want to filter by number of attendees.");
                                    Console.Write("Enter attendees number to filter meetings by: ");
                                    var filterNumber = int.Parse(Console.ReadLine()); //reik perdaryti
                                    Console.WriteLine("Choose filter type.");
                                    Console.WriteLine("A: Equal to chosen number; B: More then chosen number; C: less then chosen number;");
                                    switch (MainCommands.GetChoice4())
                                    {
                                        case "A":
                                            {
                                                var filteredMeetings = meetings?.Where(o => o._participants.Count == filterNumber).ToList();
                                                Console.WriteLine($"Meetings who have {filterNumber} attendees:");
                                                MainCommands.DisplayAllMeetings(filteredMeetings);
                                                break;
                                            }
                                        case "B":
                                            {
                                                var filteredMeetings = meetings?.Where(o => o._participants.Count >= filterNumber).ToList();
                                                Console.WriteLine($"Meetings who have more then {filterNumber} attendees:");
                                                MainCommands.DisplayAllMeetings(filteredMeetings);
                                                break;
                                            }
                                        case "C":
                                            {
                                                var filteredMeetings = meetings?.Where(o => o._participants.Count <= filterNumber).ToList();
                                                Console.WriteLine($"Meetings who have less then {filterNumber} attendees:");
                                                MainCommands.DisplayAllMeetings(filteredMeetings);
                                                break;
                                            }
                                    }
                                    break;
                                }
                        }
                        break;
                    case "E":
                        //Exit application
                        Console.WriteLine("Thank you for using this app. Have a nice day!");
                        MainCommands.SaveData(meetings, @"D:\meetingAppSaves\meetings.json");
                        programRun = false;
                        break;
                }

            }
            while (programRun);
        }
    }
}
/*
  Next: 
 * Clean up this mess above and optimise code
 * Move logic to separate file
 * Change hard coded options (meeting categories, and meeting types) to enums
 * Improove meeting class, person class
 * Figure out and implement, how best to save and load data - works kind of, needs rework 
 * Unit tests arte missing
 */