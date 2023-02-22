﻿namespace FieldDayWithOOP
{
    internal class ListMethods
    {
        #region Main methods
        /// <summary>
        /// Method to get input from the user and validate it
        /// </summary>
        /// <returns>Returns an integer entered by user</returns>
        public int GetNumber(string message)
        {
            Console.Write(message);
            var str = Console.ReadLine();
            if (!(int.TryParse(str, out var nmbr)))
                Console.WriteLine("Unrecognised input");
            return nmbr;
        }
        /// <summary>
        /// Populates list with elements given by the user
        /// </summary>
        /// <param name="chosenNumbers">List to populate</param>
        /// <param name="numberCount">Element count to be populated to the given list</param>
        /// <returns>Populated List</returns>
        public List<int> PopulateList(List<int> chosenNumbers, int numberCount)
        {
            for (var i = 0; i < numberCount; i++)
                chosenNumbers.Add(GetNumber($"Enter number {i + 1}: "));
            return chosenNumbers;
        }
        /// <summary>
        /// Displays numbers chosen by the user to the console
        /// </summary>
        /// <param name="chosenNumbers">List of numbers entered by the user</param>
        public void DisplayNumbers(List<int> chosenNumbers)
        {
            Console.WriteLine("Yor chosen numbers:");
            for (var i = 0; i < chosenNumbers.Count; i++)
                Console.Write(chosenNumbers[i] + " ");
        }
        #endregion
    }
}
