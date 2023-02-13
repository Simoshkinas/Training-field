namespace AbstractClasses
{
    /// <summary>
    /// An abstract definition of any kind of car
    /// </summary>
    public abstract class Car
    {
        #region Properties
        /// <summary>
        /// Wheek diameter of a car
        /// </summary>
        public abstract int WheelDiameterInches { get;}
        /// <summary>
        /// Indicates if a handbrake is released
        /// </summary>
        public bool HandbrakeReleased { get; set; } = false;

        #endregion
        #region Public Methods
        /// <summary>
        /// Turns the car radio on
        /// </summary>
        public virtual void RadioOn()
        {
            Console.WriteLine("Turned the radio on");
        }
        /// <summary>
        /// Attempts to release a handbrake of a car
        /// </summary>
        public virtual void ReleaseHandbrake()
        {
            // Release the handbrake
            HandbrakeReleased = true;
            Console.WriteLine("The handbrake was released successfully");
        }
        /// <summary>
        /// Gos on the gas to drive a car
        /// </summary>
        public virtual void Drive()
        {
            // Release the handbrake
            ReleaseHandbrake();
            if (HandbrakeReleased)
                Console.WriteLine("Pressed the gas pedal");
            else
                Console.WriteLine("Cannot move the car, handbrake is on");
        }

        public float GearboxOutputSpeedRpm()
        {
            return 1000;
        }
        public float CalculateSpeedMph()
        {
            // If the handbrake is on, we are not moving
            if (!HandbrakeReleased)
                return 0;
            var inchesPerRev = (float)(Math.PI * WheelDiameterInches);
            var inchesPerMinute = inchesPerRev * GearboxOutputSpeedRpm();
            var mph = inchesPerMinute * 60 * 0.0000157828;
            return (float)mph;
        }
        #endregion
        #region Abstract Methods
        /// <summary>
        /// Wind the car window down
        /// </summary>
        public abstract void WindWindowDown();
        public abstract void MoveSeatForward();
        #endregion
    }

    public class BudgetCar : Car
    {
        public override int WheelDiameterInches => 16;

        public override void MoveSeatForward()
        {
            Console.WriteLine("Moved seat forward using hand leaver");
        }

        public override void WindWindowDown()
        {
            Console.WriteLine("Lowered window using handcrank");
        }
    }
    public class SportsCar : Car
    {
        public override int WheelDiameterInches => 22;

        public override void MoveSeatForward()
        {
            Console.WriteLine("Moved seat forward using electronic ajustment system");
        }

        public override void WindWindowDown()
        {
            Console.WriteLine("Moved window down using electronic window control panel");
        }
    }

    public class BrokenBudgetCar : BudgetCar
    {
        public override void ReleaseHandbrake()
        {
            // Handbrake is always on
            HandbrakeReleased = false;
            Console.WriteLine("!! Handbrake failed to release !!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Budget Car");
            Console.WriteLine("-------------");
            var budgetCar = new BudgetCar();

            DoStuffToCar(budgetCar);
            Console.WriteLine("-----------------");

            Console.WriteLine("Sports Car");
            Console.WriteLine("-------------");
            var sportsCar = new SportsCar();

            DoStuffToCar(sportsCar);
            Console.WriteLine("-----------------");

            Console.WriteLine("Broken Budget Car");
            Console.WriteLine("-------------");
            var brokenBudgetCar = new BrokenBudgetCar();

            DoStuffToCar(brokenBudgetCar);
            Console.WriteLine("-----------------");
        }

        private static void DoStuffToCar(Car car)
        {
            car.MoveSeatForward();
            car.RadioOn();
            car.WindWindowDown();
            car.Drive();

            Console.WriteLine($"Driving ant {car.CalculateSpeedMph()} Mph, with {car.WheelDiameterInches}\" rims");
        }
    }
}