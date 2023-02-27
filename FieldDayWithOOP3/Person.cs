namespace FieldDayWithOOP3
{
    internal class Person
    {
        #region Fields
        private string _firstName, _lastName;
        #endregion
        #region Properties
        internal int Age { get; set; }
        internal string Gender { get; set; } 
        #endregion
        #region Constructor
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Gives greeting to the console
        /// </summary>
        internal void Greetings()
        {
            Console.WriteLine($"Hello, my name is {_firstName} {_lastName}");
        }
        /// <summary>
        /// Displays ful info of a person to the console
        /// </summary>
        internal void GetFullInfo()
        {
            Greetings();
            Console.WriteLine($"My Age: {Age}");
            Console.WriteLine($"My Gender: {Gender}");
            Console.WriteLine();
        }
        /// <summary>
        /// Gather input from the user
        /// </summary>
        /// <returns>Age as validated integer</returns>
        internal static int Validate()
        {
            var str = Console.ReadLine();
            if (!(int.TryParse(str, out var nmbr)) && !(nmbr < 0))
                Console.WriteLine("Unrecognised input");
            return nmbr;
        }
        #endregion
    }
}
