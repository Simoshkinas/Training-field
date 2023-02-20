//namespace BasicTraining
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            /*
//               1. Parašykite programą, kuri išvestų į ekraną, ar skaičius a yra didesnis už b.

//               2. Parašykite programą, kuri išvestų į ekraną, ar skaičius a yra didesnis, lygus ar mažesnis už b.

//               3. Parašykite programą, kuri išvestų į ekraną didžiausia skaičiu iš a, b ir c.

//               4. Parašykite programą, kuri išvestų į ekraną, ar skaičius n yra lyginis.

//               5. Parašykite programą, kuri išvestų į ekraną, ar iš trijų atkarpų a, b, c galima sudaryti trikampį.

//               6. Parašykite programą, kuri išvestų į ekraną, ar įvesti metai yra keliamieji.

//               7. Parašykite programą, kuri išvestų į ekraną kiek minučių praėjo nuo vidurnakčio. 
//                  Vartotojas įveda valandas ir minutės.
//            */

//            //1.
//            //Console.WriteLine("Enter first int a: ");
//            //var str = Console.ReadLine();
//            //if (!int.TryParse(str, out var a)) 
//            //    Console.WriteLine("Wrong type entered");
//            //Console.WriteLine("enter first int b: ");
//            //var str2 = Console.ReadLine();
//            //if (!int.TryParse(str2, out var b))
//            //    Console.WriteLine("Wrong type entered");

//            //Console.WriteLine(a > b ? $"Int a: {a} is a bigger number then int b: {b}" : $"Int a: {a} is not a bigger number then int b: {b}");


//            //2.
//            //Console.WriteLine("Enter first int a: ");
//            //var a = int.Parse(Console.ReadLine());
//            //Console.WriteLine("enter first int b: ");
//            //var b = int.Parse(Console.ReadLine());
//            //Console.WriteLine("enter first int c: ");
//            //var c = int.Parse(Console.ReadLine());

//            //if (a > b)
//            //    Console.WriteLine($"Int a: {a} is bigger then int b: {b}");
//            //else if (a < b)
//            //    Console.WriteLine($"Int a: {a} is smaller than b: {b}");
//            //else
//            //    Console.WriteLine("they are both equal");

//            //3.

//            //Console.WriteLine("Enter first int a: ");
//            //var a = int.Parse(Console.ReadLine());
//            //Console.WriteLine("enter second int b: ");
//            //var b = int.Parse(Console.ReadLine());
//            //Console.WriteLine("enter third int c: ");
//            //var c = int.Parse(Console.ReadLine());

//            //if (a > b && a > c)
//            //    Console.WriteLine($"the biggest number is a: {a}");
//            //else if (b > a && b > c )
//            //    Console.WriteLine($"the biggest number is b: {b}");
//            //else
//            //    Console.WriteLine($"the biggest number is c: {c}");

//            //4.
//            //Console.WriteLine("Enter an int n: ");
//            //var n = int.Parse(Console.ReadLine());

//            //if (n % 2 != 0)
//            //    Console.WriteLine($"Number n: {n} is an odd number");
//            //else
//            //    Console.WriteLine($"Number n: {n} is even number");

//            //5. Parašykite programą, kuri išvestų į ekraną, ar iš trijų atkarpų a, b, c galima sudaryti trikampį.

//            //Console.WriteLine("Enter the lenght of the first boarder of a triangle (a:) ");
//            //var a = double.Parse(Console.ReadLine());
//            //Console.WriteLine("Enter the lenght of the second boarder of a triangle (b:) ");
//            //var b = double.Parse(Console.ReadLine());
//            //Console.WriteLine("Enter the lenght of the third boarder of a triangle (c:) ");
//            //var c = double.Parse(Console.ReadLine());

//            //if ((a + b) >= c && (a + c) >= b && (b + c) >= a )
//            //    Console.WriteLine("A triangle can be formed using these lines");
//            //else
//            //    Console.WriteLine("A triangle cannot be formed with given conditions");

//            //6. Parašykite programą, kuri išvestų į ekraną, ar įvesti metai yra keliamieji.

//            //Console.WriteLine("Enter the year you want to check if it is a leap year: ");
//            //var str = Console.ReadLine();
//            //if (!int.TryParse(str, out var checkYear)) 
//            //    Console.WriteLine("Wrong type entered");

//            //if (checkYear % 4 == 0)
//            //{
//            //    if (checkYear % 100 == 0)
//            //    {
//            //        if (checkYear % 400 == 0)
//            //            Console.WriteLine($"{checkYear} Is a Leap Year");
//            //        else
//            //            Console.WriteLine($"{checkYear} is not a Leap Year");
//            //    }
//            //    else
//            //        Console.WriteLine($"{checkYear} Is a Leap Year");
//            //}
//            //else
//            //    Console.WriteLine($"{checkYear} is not a Leap Year");


//            //7. Parašykite programą, kuri išvestų į ekraną kiek minučių praėjo nuo vidurnakčio. Vartotojas įveda valandas ir minutes.
//            //var midnight = 0;

//            //Console.WriteLine("Please enter current hours: "); 
//            //var str = Console.ReadLine();
//            //   if (!int.TryParse(str, out var hours)) 
//            //        Console.WriteLine("Wrong type entered");
//            //Console.WriteLine("Please enter current minuites: ");
//            //var str2 = Console.ReadLine();
//            //if (!int.TryParse(str2, out var minutes))
//            //    Console.WriteLine("Wrong type entered");

//            //var minutesPassed = midnight + ((hours * 60) + minutes);
//            //Console.WriteLine($"From midnight, {minutesPassed} minutes have already passed");
//        }
//    }
//}