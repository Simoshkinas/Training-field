//using System.ComponentModel.DataAnnotations;

//namespace MessWithArrays
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
            //1. Parašykite programą, kuri suformuotų n elementų masyvą iš klaviatūra įvedamų skaičių ir atspausdintu reikšmes į ekraną.

            //2. Parašykite programą, kuri suformuotų n elementų masyvą iš klaviatūra įvedamų skaičių ir atspausdintu reikšmes į ekraną atbulinė tvarka.

            //3. Parašykite programą, kuri suformuotų n elementų masyvą iš klaviatūra įvedamų skaičių ir apskaičiuotų reikšmių sumą.

            //4. Parašykite programą, kuri suformuotų dvimatį n x m elementų masyvą iš klaviatūra įvedamų skaičių ir atspausdintu reikšmes į ekraną.

            //5. Parašykite programą, kuri suformuotų du dvimačius n x m elementų masyvus iš klaviatūra įvedamų skaičių ir sudetu ju reikšmes į trečia n x m dvimatį masyvą.


            //1. 

            //Console.WriteLine("Enter number of elements:");

            //var str = Console.ReadLine();
            //if (!(int.TryParse(str, out var n))) 
            //{
            //    Console.WriteLine("Unrecognised input");
            //}
            //var arr = new int[n];

            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    var str1 = Console.ReadLine();
            //    if (!(int.TryParse(str1, out var x)))
            //    {
            //        Console.WriteLine("Unrecognised input");
            //    }
            //    arr[i] = x;
            //}
            //for (int i = 0; i < arr.Length; i++)
            //    Console.Write(arr[i] + " ");


            //2. 

            //Console.WriteLine("Enter number of elements:");

            //var str = Console.ReadLine();
            //if (!(int.TryParse(str, out var n))) 
            //{
            //    Console.WriteLine("Unrecognised input");
            //}
            //var arr = new int[n];

            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    var str1 = Console.ReadLine();
            //    if (!(int.TryParse(str1, out var x)))
            //    {
            //        Console.WriteLine("Unrecognised input");
            //    }
            //    arr[i] = x;
            //}
            //for (int i = arr.Length - 1; i >= 0; i--)
            //    Console.Write(arr[i] + " ");

            //3. 

            //Console.WriteLine("Enter number of elements:");

            //var str = Console.ReadLine();
            //if (!(int.TryParse(str, out var n))) 
            //{
            //    Console.WriteLine("Unrecognised input");
            //}
            //var arr = new int[n];
            //var sum = 0;
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    var str1 = Console.ReadLine();
            //    if (!(int.TryParse(str1, out var x)))
            //    {
            //        Console.WriteLine("Unrecognised input");
            //    }
            //    sum += (arr[i] = x);
            //}
            //Console.WriteLine(sum);

            //4. 

            //var str1 = Console.ReadLine();
            //if (!(int.TryParse(str1, out var n))) 
            //    Console.WriteLine("Unrecognised input");
            //var str2 = Console.ReadLine();
            //if (!(int.TryParse(str2, out var m)))
            //    Console.WriteLine("Unrecognised input");

            //var arr = new int[n, m];

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        var str3 = Console.ReadLine();
            //        if (!(int.TryParse(str3, out var x)))
            //        {
            //            Console.WriteLine("Unrecognised input");
            //        }
            //        arr[i, j] = x;
            //    }    
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //        Console.Write(arr[i, j] + " ");
            //}

            //5. 

            //var str1 = Console.ReadLine();
            //if (!(int.TryParse(str1, out var n)))
            //    Console.WriteLine("Unrecognised input");
            //var str2 = Console.ReadLine();
            //if (!(int.TryParse(str2, out var m)))
            //    Console.WriteLine("Unrecognised input");

            //var arr = new int[n, m];
            //var arr2 = new int[n, m];
            //var arrSum = new int[n, m]; 
            //Console.WriteLine("enter elements of first array");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        var str3 = Console.ReadLine();
            //        if (!(int.TryParse(str3, out var x)))
            //        {
            //            Console.WriteLine("Unrecognised input");
            //        }
            //        arr[i, j] = x;
            //    }
            //}
            //Console.WriteLine("Enter elements of second array");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        var str3 = Console.ReadLine();
            //        if (!(int.TryParse(str3, out var x)))
            //        {
            //            Console.WriteLine("Unrecognised input");
            //        }
            //        arr2[i, j] = x;
            //    }
            //}
            //Console.WriteLine("Sum of elements of each array are: ");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //       Console.Write((arrSum[i, j] = arr[i, j] + arr2[i, j]) + " ");
            //    }
            //}
            
//        }
//    }
//}