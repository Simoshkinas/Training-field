using System.Dynamic;

namespace ATM
{
    internal static class BasicCommands
    {
        internal static string GetText() => Console.ReadLine();
        internal static void DisplayOptionsStart()
        {
            Console.WriteLine("A: Enter new User    B: Log in with an existing User   C: Exit the application");
        }
        internal static string GetFirstOptions() 
        {
            var str = Console.ReadLine().ToUpper();
            if (str != "A" || str != "B" || str != "C")
                Console.WriteLine("Wrong input, try again");
            return str;
            
        }
        internal static int GetPin()
        {
            var str = Console.ReadLine();
            if (!(int.TryParse(str, out var nmbr)))
                Console.WriteLine("Unrecognised input");
            return nmbr;
        }
        internal static double GetBalance()
        {
            var str = Console.ReadLine();
            if (!(double.TryParse(str, out var nmbr)))
                Console.WriteLine("Unrecognised input");
            return nmbr;
        }
    }
}
