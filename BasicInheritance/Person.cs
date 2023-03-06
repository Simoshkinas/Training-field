namespace BasicInheritance
{
    internal class Person
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal int Age { get; set; }

        internal Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        internal virtual void Greetings()
        {
            Console.WriteLine($"Greetings, my name is: {FirstName} {LastName}");
        }
        internal virtual double GetSalary() => 0;
        internal virtual double GetSalary(double bonus) => 0;
    }
}
