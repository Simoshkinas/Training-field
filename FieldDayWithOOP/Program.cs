namespace FieldDayWithOOP
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //Example of static Class
            #region Actions with Arrays
            Console.WriteLine("Enter the number of rows:");
            var row = ArrayCalc.GetNumber();

            Console.WriteLine("Enter the number of columns:");
            var col = ArrayCalc.GetNumber();

            Console.WriteLine("Enter elements of first array");
            var arr1 = ArrayCalc.ReadArray(row, col);
            ArrayCalc.DisplayArray(row, col, arr1);

            Console.WriteLine("Enter elements of second array");
            var arr2 = ArrayCalc.ReadArray(row, col);
            ArrayCalc.DisplayArray(row, col, arr2);

            Console.WriteLine("Sum of elements of each array are: ");
            var arrSum = ArrayCalc.SumArrays(arr1, arr2, row, col);
            ArrayCalc.DisplayArray(row, col, arrSum);
            #endregion

            //Example of non-static Class
            #region Actions with List 
            var listMethods = new ListMethods();
            var chosenNumbers = new List<int>();
            // User defines number of elements he want to put in a list
            var numberCount = listMethods.GetNumber("Enter, how many numbers there will be in a list:");

            // User enter elements in a list
            listMethods.PopulateList(chosenNumbers, numberCount);

            // Program displays already populated List to console
            listMethods.DisplayNumbers(chosenNumbers);
            #endregion
        }
    }
}