namespace MeetingApp
{
    internal class Meeting
    {
        internal List<Person> ? Participants { get; set; }
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal Person ResponsiblePerson { get; set; }
        internal string Category { get; set; }
        internal string Type { get; set; }
        internal DateTime StartDate { get; set; }
        internal DateTime EndDate { get; set; }
        /// <summary>
        /// Constructor with parameters to create a new meeting object
        /// </summary>
        /// <param name="name">Name of meeting</param>
        /// <param name="description">Meeting description</param>
        /// <param name="responsiblePerson">Person responsible for that meeting</param>
        /// <param name="category">Meeting category</param>
        /// <param name="type">meeting type</param>
        /// <param name="startDate">Starting date of this meeting</param>
        /// <param name="endDate"></param>
        internal Meeting(string name, 
                         string description, 
                         Person responsiblePerson, 
                         string category, 
                         string type, 
                         DateTime startDate, 
                         DateTime endDate)
        {
            Name = name;
            Description = description;
            ResponsiblePerson = responsiblePerson;
            Category = category;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            Participants = new List<Person>();
        }        
    }
}
