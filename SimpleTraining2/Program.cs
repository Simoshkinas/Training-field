//namespace SimpleTraining2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
            //1. Parašykite programą, kuri išvestų į ekraną, skaičius nuo 1 iki 10.

            //2. Parašykite programą, kuri išvestų į ekraną, skaičius nuo 1 iki n.

            //3. Parašykite programą, kuri išvestų į ekraną, lyginius skaičius nuo 1 iki n.

            //4. Parašykite programą, kuri išvestų į ekraną, skaičių sumą nuo 1 iki n.

            //5. Parašykite programą, kuri apskaičiuotų n klaviatūra įvedamų skaičių sumą.

            //6. Parašykite programą, kuri apskaičiuotų lyginių ir nelyginių skaičių suma. n skaičių įvedami vartotojo.

            //7. Parašykite programą, kuri apskaičiuotų DBD(didžiausias bendras daliklis). Naudokite Euklido algoritmą.

            //8. Parašykite programą, kuri apskaičiuotų n-ojo Fibonačio skaičiaus reikšmė.

            //1.

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //2. 

            //Console.Write("Please, enter the desired number 'n': ");
            //var str = Console.ReadLine();
            //if (!int.TryParse(str, out var n))
            //    Console.WriteLine("Wrong input");
            //for (int i = 1; i <= n; i++)
            //    Console.WriteLine(i);

            //3.

            //Console.Write("Please, enter the desired number 'n': ");
            //var str = Console.ReadLine();
            //if (!int.TryParse(str, out var n))
            //    Console.WriteLine("Wrong input");
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //4.

            //Console.Write("Please, enter the desired number 'n': ");
            //var str = Console.ReadLine();
            //if (!int.TryParse(str, out var n))
            //    Console.WriteLine("Wrong input");

            //int sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //   sum += i;
            //}
            //Console.WriteLine(sum);

            //5. 

            //Console.Write("Please, enter, how many numbers you want to add: ");
            //var str = Console.ReadLine();
            //if (!int.TryParse(str, out var n))
            //    Console.WriteLine("Wrong input");
            //int[] members = new int[n];
            //int sum = 0;
            //for (int i = 0; i < members.Length; i++)
            //   sum += (members[i] = i+1);
            //Console.WriteLine($"The sum of your numbers is: {sum}");

            //6. 

            //Console.Write("Please, enter, how many numbers you want to add: ");
            //var str = Console.ReadLine();
            //if (!int.TryParse(str, out var n))
            //    Console.WriteLine("Wrong input");
            //int[] members = new int[n];
            //int sum1 = 0;
            //int sum2 = 0;
            //for (int i = 0; i < members.Length; i++)
            //    members[i] = int.Parse(Console.ReadLine());
            //for (int i = 0; i < members.Length; i++)
            //{
            //    if (!(members[i] % 2 == 0))
            //    {
            //        sum1 += members[i];
            //    }
            //    else
            //        sum2 += members[i];
            //}
            //Console.WriteLine($"The sum of your odd numbers is: {sum1}");
            //Console.WriteLine($"the sum of your even numbers is: {sum2}");

            //7. Parašykite programą, kuri apskaičiuotų DBD(didžiausias bendras daliklis). Naudokite Euklido algoritmą.

            //uint x; 
            //uint y;

            //Console.Write("Enter the First Number: ");
            //x = uint.Parse(Console.ReadLine());

            //Console.Write("Enter the Second Number: ");
            //y = uint.Parse(Console.ReadLine());

            //uint Remainder;

            //while (y != 0)
            //{
            //    Remainder = x % y;
            //    x = y;
            //    y = Remainder;
            //}
            //Console.Write($"The Greatest Common Divisor: {x}");


            //8. Parašykite programą, kuri apskaičiuotų n-ojo Fibonačio skaičiaus reikšmė.

            //int n1 = 0;
            //int n2 = 1;
            //int n3; 
            //int number;
            //Console.Write("Enter the number of elements: ");
            //number = int.Parse(Console.ReadLine());
            //Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            //for (int i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            //{
            //    n3 = n1 + n2;
            //    Console.Write(n3 + " ");
            //    n1 = n2;
            //    n2 = n3;
            //}
//        }
//    }
//}
    