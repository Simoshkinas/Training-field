namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Base Class - Derived Class
            // 2. Constructor
            // 3. Casting
            // 4. Sealed
            // 5. Inheriting an inherited Class

            //var car = new Car();
            var ferrari488 = new Ferrari488(16);
            var ferrari = (Ferrari)ferrari488;

            var car = (Car)ferrari;

            
        }
    }

    public class Car
    {
        public int WheelSize { get; set; }
        public int NumberOfDoors { get; set; }

        public Car() 
        { 
        }
        public Car(int wheelSize)
        {
            WheelSize = wheelSize;
        }
    }
    public class Ferrari : Car
    {
        public int ModelNumber { get; set; }
        public Ferrari()
        {

        }
        public Ferrari(int wheelSize) : base(wheelSize) 
        {
            
        }
    }
    public class Ferrari488 : Ferrari
    {
        public Ferrari488(int wheelSize) : base(wheelSize)
        {

        }
    }
}