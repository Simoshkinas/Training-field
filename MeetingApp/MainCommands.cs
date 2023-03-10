using Newtonsoft.Json;

namespace MeetingApp
{
    internal static class MainCommands
    {
        /// <summary>
        /// Displays a greeting message
        /// </summary>
        internal static void GiveGreeting()
        {
            Console.WriteLine("Welcome to the MeetingAPP");
        }
        /// <summary>
        /// Displays choises for the user to take at the start of the app.
        /// </summary>
        internal static void DisplayStartingChoises()
        {
            Console.WriteLine("Please, choose the following: ");
            Console.WriteLine("A: Create a new Meeting; B: Add person to a meeting; C: List all meetings; D: Exit application; ");
        }
        /// <summary>
        /// Reads, what was chosen by the user, and validates input. If inpud was incorrect, asks again to choose correctly
        /// </summary>
        /// <returns>Returns input value</returns>
        internal static string GetChoice(string choice)
        {
            string validatedChoice;
            while (true)
            {
                if (choice.Length > 0 && (choice == "A" || choice == "B" || choice == "C" || choice == "D"))
                {
                    validatedChoice = choice;
                    break;
                }
                else
                    Console.WriteLine("Wrong input, try again: ");
                    choice = Console.ReadLine().ToUpper();
            }
            return validatedChoice;
        }
        /// <summary>
        /// Gives a specific Category, which is predefined value, tu the particular meeting
        /// </summary>
        /// <param name="choice">Choice value given by the user</param>
        /// <returns>Predefined value of category chosen by the user</returns>
        internal static string GetCategory(string choice)
        {
            switch (choice) 
            {
                case "A":
                    choice = "CodeMonkey";
                    break;
                case "B":
                    choice = "Hub";
                    break;
                case "C":
                    choice = "Short";
                    break;
                case "D":
                    choice = "TeamBuilding";
                    break;
            }
            return choice;
        }
        /// <summary>
        /// Validates and sets meeting type based by the choice of the user
        /// </summary>
        /// <param name="choice">User input based of Fixed values</param>
        /// <returns>Returns fixed value of Meeting Type </returns>
        internal static string GetType(string choice)
        {
            string validatedChoice;
            while (true)
            {
                if (choice.Length > 0 && (choice == "A" || choice == "B"))
                {
                    validatedChoice = choice;
                    break;
                }
                else
                    Console.WriteLine("Wrong input, try again: ");
                choice = Console.ReadLine().ToUpper();
            }
            switch (validatedChoice)
            {
                case "A":
                    validatedChoice = "Live";
                    break;
                case "B":
                    validatedChoice = "InPerson";
                    break;
            }
            return validatedChoice;
        }
        /// <summary>
        /// Reads input of the user, and prevents entering blank text.
        /// </summary>
        /// <param name="input">Input which is reead from the console that user has entered</param>
        /// <returns>validated input</returns>
        internal static string GatherInput(string input) 
        {
            string validatedInput;
            while (true)
            {
                if (input.Length > 0)
                {
                    validatedInput = input;
                    break;
                }
                else
                    Console.WriteLine("Wrong input, try again: ");
                input = Console.ReadLine();
            }
            return validatedInput;
        }
        /// <summary>
        /// Reads ID given by the user, a specific parameter, which is validated
        /// </summary>
        /// <returns>Returns a validated ID value</returns>
        internal static int GetId()
        {
            var str = Console.ReadLine();
            if (!(int.TryParse(str, out var number)))
                Console.WriteLine("Unrecognised input:");
            return number;
        }
        /// <summary>
        /// Reads date from User input, and validates value
        /// </summary>
        /// <returns>Returns validated date</returns>
        internal static DateTime GetDateTime(string message)
        {
            Console.WriteLine(message);
            DateTime enteredDate;
            while (!DateTime.TryParse(Console.ReadLine(), out enteredDate))
            {
                Console.WriteLine("Invalid input. Please enter a valid date and time (MM/dd/yyyy hh:mm:ss): ");
            }
            return enteredDate;
        }
        /// <summary>
        /// Creates a new Meeting
        /// </summary>
        /// <param name="name">Name of meeting</param>
        /// <param name="description">Meeting description</param>
        /// <param name="responsiblePerson">Person responsible for a particular meeting</param>
        /// <param name="category">Meeting category</param>
        /// <param name="type">Meeting type</param>
        /// <param name="startDate">Meeting start date</param>
        /// <param name="endDate">Meeting end date</param>
        internal static Meeting CreateMeeting(string name,
                                              string description,
                                              Person responsiblePerson,
                                              string category,
                                              string type,
                                              DateTime startDate,
                                              DateTime endDate)
        {
            return new Meeting(name, description, responsiblePerson, category, type, startDate, endDate);
        }
/// <summary>
/// Deletes meeting from meeting list and file
/// </summary>
/// <param name="meetings">Meeting list from witch a single meeting will be removed</param>
/// <param name="meeting">A specific meeting to be removed</param>
/// <param name="responsiblePerson">Person, who is responsible for a particular meeting</param>
        internal static void DeleteMeeting(List<Meeting> meetings, Meeting meeting, Person responsiblePerson) 
        {
            if (responsiblePerson != meeting.ResponsiblePerson)
                Console.WriteLine("Delete meeting failed. Only responsible person can delete this meeting.");
            else
                meetings.Remove(meeting);
        }
        /// <summary>
        /// Removes a participant from a specific meeting
        /// </summary>
        /// <param name="meeting">Specific meeting from witch a participant will be removed</param>
        /// <param name="memeber">Participant to be removed</param>
        internal static void RemoveParticipant(Meeting meeting, Person memeber)
        {
            if (meeting.ResponsiblePerson.Id == memeber.Id)
                Console.WriteLine("Responsible person cannot be removed from this particular meeting.");
            else
                meeting._participants.Remove(meeting._participants.FirstOrDefault(memeber));
        }
        /// <summary>
        /// Displays a full info of a particular meeting (unfinished, filters needed)
        /// </summary>
        /// <param name="meeting">Specific meeting, who's info is to be displayed</param>
        internal static void DisplayFullInfo(Meeting meeting)
        {
            Console.WriteLine($"Meeting name: {meeting.Name}");
            Console.WriteLine($"Meeting Description: {meeting.Description}");
            Console.WriteLine($"Meeting Responsible person: { meeting.ResponsiblePerson.FirstName} {meeting.ResponsiblePerson.LastName}");
            Console.WriteLine($"Meeting Category: {meeting.Category}");
            Console.WriteLine($"Meeting Type: {meeting.Type}");
            Console.WriteLine($"Meeting Start date: {meeting.StartDate}");
            Console.WriteLine($"Meeting End date: {meeting.EndDate}");
            DisplayParticipants(meeting);
            Console.WriteLine();
        }
        /// <summary>
        /// Saves a meeting to JSON file (unfinished)
        /// </summary>
        /// <param name="meeting">Specific meeting, who's data will be saved</param>
        internal static void SaveData(Meeting meeting, string path)
        {
            string json = JsonConvert.SerializeObject(meeting, Formatting.Indented);
            File.WriteAllText(path, json);
        }
        /// <summary>
        /// Displays all members of a meeting (unfinished, filters needed)
        /// </summary>
        /// <param name="meeting">Specific meeting, who's participants will be displayed</param>
        internal static void DisplayParticipants(Meeting meeting)
        {
            Console.WriteLine("Members of the meeting:");
            for (var i = 0; i < meeting._participants.Count; i++)
                Console.WriteLine($"{ meeting._participants[i].FirstName} { meeting._participants[i].LastName}");
        }
        /// <summary>
        /// Adds a person to the participants of that meeting (not finished).
        /// </summary>
        /// <param name="meeting">A meeting, to witch a participant will be added</param>
        /// <param name="member">A person, who will be added to the participants list</param>
        internal static void AddParticipant(Meeting meeting, Person member)
        {
            if (meeting._participants.Contains(member) || meeting.ResponsiblePerson.Id == member.Id)
                Console.WriteLine("This person is already in a meeting. Unable to add.");
            else
                meeting._participants.Add(member);
        }
        /// <summary>
        /// Displays list of all meetings (unfinished, filters needed)
        /// </summary>
        /// <param name="meetings">List of all meetings to be displayed</param>
        internal static void DisplayAllMeetings(List<Meeting> meetings) 
        {
            for (var i = 0; i < meetings.Count; i++)
                Console.WriteLine($"{meetings[i].Name}");
        }
    }
}
