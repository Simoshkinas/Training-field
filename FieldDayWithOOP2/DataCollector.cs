namespace FieldDayWithOOP2
{
    /// <summary>
    /// Collects data from the user which is necessary for this app
    /// </summary>
    internal static class DataCollector
    {
        /// <summary>
        /// Gather input from the user
        /// </summary>
        /// <param name="message">Description of data the User has to input</param>
        /// <returns></returns>
        public static double EnterDimension (string message)
        {
            Console.WriteLine (message);
            var str = Console.ReadLine();
            if (!(int.TryParse(str, out var nmbr)))
                Console.WriteLine("Unrecognised input");
            return nmbr;
        }
    }
}
