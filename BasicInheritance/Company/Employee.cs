namespace BasicInheritance.Company
{
    internal class Employee : Person
    {
        private readonly double _totalWorkHours;
        private readonly double _pricePerHour;
        internal Employee(string firstName, string lastName, double totalWorkHours, double pricePerHour) : base(firstName, lastName)
        {
            _totalWorkHours = totalWorkHours;
            _pricePerHour = pricePerHour;
        }
        internal override void Greetings()
        {
            Console.WriteLine($"Hello, I am an employee {FirstName} {LastName}");
        }
        internal void Work() 
        {
            Console.WriteLine("I am currently working");
        }
        /// <summary>
        /// Calculates salary of an employee (Method override example).
        /// </summary>
        /// <returns>Returns salary of an employee</returns>
        internal override double GetSalary() => _pricePerHour * _totalWorkHours;
        /// <summary>
        /// Calculates total to be paid to the employee (Method overload example) 
        /// </summary>
        /// <param name="bonus">Bonus to be added to the salary</param>
        /// <returns>Retuirns total sum to be paid to the employee (Salary plus bonus)</returns>
        internal override double GetSalary(double bonus) => GetSalary() + bonus;


    }
}
