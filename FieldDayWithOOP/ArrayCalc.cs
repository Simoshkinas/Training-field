namespace FieldDayWithOOP
{
    internal static class ArrayCalc
    {
        

        #region Main Methods
        /// <summary>
        /// Method to get input from the user and validate it
        /// </summary>
        /// <returns>Returns an integer entered by user</returns>
        public static int GetNumber()
        {
            var str = Console.ReadLine();
            if (!(int.TryParse(str, out var nmbr)))
                Console.WriteLine("Unrecognised input");
            return nmbr;
        }
        /// <summary>
        /// Method to form a multidimensional array
        /// </summary>
        /// <param name="row">Number of rows of an array</param>
        /// <param name="col">Number of columns of an array</param>
        /// <returns>Returns multidimensional array with assigned values</returns>
        public static int[,] ReadArray(int row, int col)
        {
            var array = new int[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    array[i, j] = GetNumber();
            return array;
        }
        /// <summary>
        /// Adds each value of both arrays with each other by the same index and returs new array of sum results
        /// </summary>
        /// <param name="arr1">First array to pass</param>
        /// <param name="arr2">Second Array to pass</param>
        /// <param name="row">Number of rows in all arrays</param>
        /// <param name="col">Number of columns in all arrays</param>
        /// <returns>New array with values added together</returns>
        public static int[,] SumArrays(int[,] arr1, int[,] arr2, int row, int col)
        {
            var arrSum = new int[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    arrSum[i, j] = arr1[i, j] + arr2[i, j];
            return arrSum;
        }
        /// <summary>
        /// Displays an array with it's elements 
        /// </summary>
        /// <param name="row">Number of rows of an array</param>
        /// <param name="col">Number of columns of an array</param>
        /// <param name="array">Array to be displayed</param>
        public static void DisplayArray(int row, int col, int[,] array)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }
        }
        #endregion
    }
}
