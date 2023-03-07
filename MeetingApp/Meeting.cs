using System;

namespace MeetingApp
{
    internal class Meeting
    {
        #region Fields
        internal List<Person> _participants;
        #endregion
        #region Properties
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal Person ResponsiblePerson { get; set; }
        internal string Category { get; set; }
        internal string Type { get; set; }
        internal string StartDate { get; set; }
        internal string EndDate { get; set; }
        #endregion
        #region Constructor
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
                         string startDate, 
                         string endDate)
        {
            Name = name;
            Description = description;
            ResponsiblePerson = responsiblePerson;
            Category = category;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            _participants = new List<Person>();
        }
        #endregion
    }
}
