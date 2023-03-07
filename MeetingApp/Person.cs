namespace MeetingApp
{
    internal class Person
    {
        #region Properties
        internal int Id { get; set; }
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        #endregion
        #region Constructor
        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion
    }
}
