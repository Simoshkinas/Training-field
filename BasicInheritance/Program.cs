using BasicInheritance.Company;

namespace BasicInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee("John", "Wick", 40, 7);

            emp.Greetings();
            emp.Work();
            Console.WriteLine(emp.GetSalary());
            
        }
    }
}