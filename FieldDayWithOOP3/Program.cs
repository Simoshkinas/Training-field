namespace FieldDayWithOOP3
{
    internal class Program
    {
        /*
        Sukurkite klasė Person, kuriai per konsruktoriu paduokite firstName ir lastName;
        Pridėkite Age ir Gender properties. Patikrinkite ar Age yra neneigiamas;
        Realizuolite metodą Greetings, kuris atspausdins į konsolę: Hello, my name is {firstName} {lastName};
        Realizuokite metodą GetFullInfo, kuris atspausdins į konsolę:

        Hello, my name is {firstName} {lastName}
        My age: {Age}
        My gender: {Gender}
        DONE 
        Vartotojas įveda skaičių n. DONE
        Programa paprašo įvesti n žmonių vardą, pavardę, amžių ir lytį. DONE
        Programa atspausdina į ekraną visų žmonių  vardą, pavardę, amžių ir lytį, naudojant GetFullInfo metodą. DONE
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter desired number of persons: ");
            var str = Console.ReadLine();
            if (!(int.TryParse(str, out var number)))
                Console.WriteLine("Unrecognised input");
            var n = number;
            var persons = new List<Person>();
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Enter first name: ");
                var firstName = Console.ReadLine();
                Console.WriteLine("Enter last name:");
                var lastName = Console.ReadLine();
                var person = new Person(firstName, lastName);
                Console.WriteLine("Enter Age:");
                person.Age = Person.Validate();
                Console.WriteLine("Enter gender:");
                person.Gender = Console.ReadLine();
                persons.Add(person);
            }
            Console.WriteLine("List of persons are: ");
            for (var i = 0; i < n; i++)
            {
                persons[i].GetFullInfo();
            }
        }
    }
}