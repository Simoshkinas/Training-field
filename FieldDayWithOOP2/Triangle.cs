namespace FieldDayWithOOP2
{
    internal class Triangle : Geometry
    {
        #region Fields
        private double _a;
        private double _b;
        private double _c;
        #endregion
        #region Constructor
        internal Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        #endregion
        #region Methods
        internal override double GetArea()
        {
            return Math.Sqrt((GetPerimeter()/2) * 
                            ((GetPerimeter()/2) - _a) * 
                            ((GetPerimeter() / 2) - _b) * 
                            ((GetPerimeter() / 2) - _b));
        }
        internal override double GetPerimeter()
        {
            return _a + _b + _c;
        }
        internal override void DisplayFigure()
        {
            Console.WriteLine($"Area of a Triangle: {GetArea()}");
            Console.WriteLine($"Perimeter of a Triangle: {GetPerimeter()}");
        }
        #endregion
    }
}
